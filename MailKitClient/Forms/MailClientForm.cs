using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MailKitClient.MailKit;
using MimeKit;

namespace MailKitClient.Forms
{
    public partial class MailClientForm : Form
    {
        private const string SmtpClientHost = "smtp.yeah.net";
        private const int SmtpClientPort = 25;
        private const string UserName = "SystemRC";
        private const string UserAddress = "SystemRC@yeah.net";
        private const string Password = "SystemRC123";

        MailKitSender mailKitSender;

        MailKitReceiver mailKitReceiver = new MailKitReceiver();

        public MailClientForm()
        {
            this.InitializeComponent();
        }

        private void MailClientForm_Shown(object sender, System.EventArgs e)
        {
            this.mailKitSender = new MailKitSender(
                SmtpClientHost,
                SmtpClientPort,
                UserAddress,
                Password);
        }

        private MimeMessage CreateMailMessage()
        {
            var message = new MimeMessage();

            var sender = new MailboxAddress(UserName, UserAddress);
            var receivers = this.ReceiverTextBox.Text.Split(';').Select(address => new MailboxAddress(address.Trim())).ToList();
            var subject = this.SubjectTextBox.Text;
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = this.BodyTextBox.Text
            };
            if (this.AttachmentLabel.Tag is string[] attachs)
            {
                foreach (string path in attachs)
                {
                    var bytes = File.ReadAllBytes(path);
                    var attachment = bodyBuilder.Attachments.Add(path, bytes);
                }
            }
            var body = bodyBuilder.ToMessageBody();

            message.From.Add(sender);
            message.To.AddRange(receivers);
            message.Subject = subject;
            message.Body = body;
            message.Date = DateTime.Now;

            return message;
        }

        private void AttachmentButton_Click(object sender, System.EventArgs e)
        {
            using (var dialog = new OpenFileDialog()
            {
                Filter = "*.*|*.*",
                Multiselect = true,
                Title = "请选择附件文件：",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            })
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var attachments = dialog.FileNames;
                this.AttachmentLabel.Tag = attachments;
                this.AttachmentLabel.Text = $"共 {attachments.Length} 个文件：{string.Join("、", attachments.Select(attach => Path.GetFileName(attach)))}";
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            this.SendButton.Enabled = false;

            bool retry;
            do
            {
                try
                {
                    var message = this.CreateMailMessage();
                    this.mailKitSender.Send(message);

                    retry = false;
                    MessageBox.Show($"邮件成功发送到 {message.To.Count} 个联系人：\n{string.Join("\n", message.To.Cast<MailboxAddress>().Select((to, index) => $"\t{index}：{to.Address}"))}");
                }
                catch (Exception ex)
                {
                    retry = MessageBox.Show($"发送失败：\n{ex.Message}", "发送失败，是否重试？", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry;
                }
            }
            while (retry);

            this.SendButton.Enabled = true;
        }
    }
}

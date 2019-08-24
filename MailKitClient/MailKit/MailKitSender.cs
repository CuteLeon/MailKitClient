using MailKit.Net.Smtp;
using MimeKit;

namespace MailKitClient.MailKit
{
    public class MailKitSender
    {
        public MailKitSender()
        {
        }

        public MailKitSender(
            string smtpClientHost,
            int smtpClientPort,
            string userAddress,
            string password)
        {
            this.SmtpClientHost = smtpClientHost;
            this.SmtpClientPort = smtpClientPort;
            this.UserAddress = userAddress;
            this.Password = password;
        }

        public string SmtpClientHost { get; set; }

        public int SmtpClientPort { get; set; }

        public string UserAddress { get; set; }

        public string Password { get; set; }

        public void Send(MimeMessage message)
        {
            using (var client = new SmtpClient())
            {
                client.Connect(this.SmtpClientHost, this.SmtpClientPort, false);
                client.Authenticate(this.UserAddress, this.Password);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}

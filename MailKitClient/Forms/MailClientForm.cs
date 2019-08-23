using System.Windows.Forms;
using MailKitClient.MailKit;

namespace MailKitClient.Forms
{
    public partial class MailClientForm : Form
    {
        MailKitSender mailKitSender = new MailKitSender();

        MailKitReceiver mailKitReceiver = new MailKitReceiver();

        public MailClientForm()
        {
            this.InitializeComponent();
        }
    }
}

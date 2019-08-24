using System;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;

namespace MailKitClient.MailKit
{
    public class MailKitReceiver
    {
        public MailKitReceiver()
        {
        }

        public MailKitReceiver(
            string imapClientHost,
            int imapClientPort,
            string userAddress,
            string password)
        {
            this.ImapClientHost = imapClientHost;
            this.ImapClientPort = imapClientPort;
            this.UserAddress = userAddress;
            this.Password = password;
        }

        public string ImapClientHost { get; set; }

        public int ImapClientPort { get; set; }

        public string UserAddress { get; set; }

        public string Password { get; set; }

        public void ReceiveMails()
        {
            using (var client = new ImapClient())
            {
                client.Connect(this.ImapClientHost, this.ImapClientPort, false);
                client.Authenticate(this.UserAddress, this.Password);
                client.Inbox.Open(FolderAccess.ReadOnly);
                var uids = client.Inbox.Search(SearchQuery.All);
                foreach (var uid in uids)
                {
                    var message = client.Inbox.GetMessage(uid);
                    Console.WriteLine(message.TextBody);
                    // message.WriteTo($"{uid}.eml");
                }

                client.Disconnect(true);
            }
        }
    }
}

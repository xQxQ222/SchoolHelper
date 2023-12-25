using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace SchoolHelperApp
{
    public class ChatMessage
    {
        public int id;
        public string recipient;
        public string sender;
        public string messageText;
        public DateTime messageDate;
        public ChatMessage(int id,User recipient,User sender,string messageText)
        {
            this.id = id;
            this.recipient = recipient._login;
            this.sender = sender._login;
            this.messageText = messageText;
            this.messageDate = DateTime.Now;
        }
        public ChatMessage(User recipient, User sender, string messageText)
        {
            this.recipient = recipient._login;
            this.sender = sender._login;
            this.messageText = messageText;
            this.messageDate = DateTime.Now;
        }
        public ChatMessage(string recipientLogin,User sender,string messageText)
        {
            this.recipient=recipientLogin;
            this.sender=sender._login;
            this.messageText=messageText;
            this.messageDate = DateTime.Now;
        }
        public ChatMessage(int id, string recipient, string sender, string messageText)
        {
            this.id = id;
            this.recipient = recipient;
            this.sender = sender;
            this.messageText = messageText;
            this.messageDate = DateTime.Now;
        }
        public ChatMessage(string recipient, string sender, string messageText)
        {
            this.recipient = recipient;
            this.sender = sender;
            this.messageText = messageText;
            this.messageDate = DateTime.Now;
        }
    }
}

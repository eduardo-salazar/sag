using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Sistema_De_Administracion_De_Servicios
{
    class OutlookEmailSender2
    {
        Outlook.MailItem olMailItem;
        Outlook.Recipients olRecipients;
        Boolean sent;
        public String message;
        public String subject;
        String sender;
        String recipients;

        public String Sender {
            get { return sender; }
        }

        public String Recipients {
            get { return recipients; }
        }

        public Boolean Sent {
            get { return sent; }
        }


        public OutlookEmailSender2()
        {
            Outlook.Application olApplication = new Outlook.Application();
            Outlook.NameSpace olNameSpace = olApplication.GetNamespace("mapi");
            olNameSpace.Logon(Type.Missing, Type.Missing, true, true);
            olMailItem = (Outlook.MailItem)olApplication.CreateItem(Outlook.OlItemType.olMailItem);
            olRecipients = olMailItem.Recipients;
            olApplication.ItemSend += new Outlook.ApplicationEvents_11_ItemSendEventHandler(olApplication_ItemSend);
        }

        void olApplication_ItemSend(object Item, ref bool Cancel)
        {
            try
            {
                subject = olMailItem.Subject;
                message = olMailItem.Body;
                int count = 0;
                foreach (Outlook.Recipient r in olRecipients)
                {
                    if (count != 0) recipients += "; ";
                    recipients += r.Address;
                    count++;
                }
                Outlook.Account account = olMailItem.SendUsingAccount;
                if (account != null)
                {
                    sender = account.DisplayName;
                }
                else
                {
                    sender = olMailItem.Session.CurrentUser.Address;
                }
                sent = true;
            }catch(Exception e){
                sent = false;
            }
        }

        public void setSubject(String subject) {
            olMailItem.Subject = subject;
            this.subject = subject;
        }

        public void setMessage(String messaje) {
            olMailItem.Body = messaje;
        }

        public void addRecipient(String recipient, Outlook.OlMailRecipientType olMailRecipientType) {
            if (ExpressionValidator.ExpressionValidator.isEmail(recipient.Replace(" ","")))
            {
                Outlook.Recipient olRecipient = (Outlook.Recipient)olRecipients.Add(recipient);
                olRecipient.Type = (int)olMailRecipientType;
            }
        }

        public void addRecipients(String[] recipients, Outlook.OlMailRecipientType olMailRecipientType) { 
            foreach(String recipient in recipients){
                addRecipient(recipient, olMailRecipientType);
            }
        }

        public void addRecipients(String recipients, Outlook.OlMailRecipientType olMailRecipientType)
        {
            String[] recipientString=recipients.Trim().Split(';');
            addRecipients(recipientString, olMailRecipientType);
        }

        public void sendThroughOutlook(Boolean modal) {
            olMailItem.Display(modal);
        }
    }
}

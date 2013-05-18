using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Sistema_De_Administracion_De_Servicios
{
    class OutlookEmailSender
    {
        public static Boolean sendEmail(String subject, String message, String toRecipients, String toCc, String toCco, String[] attachmentsSources)
        {
            Boolean sent = false;
            try
            {
                Outlook.Application outlookApplication = new Outlook.Application();
                Outlook.NameSpace outlookNameSpace = outlookApplication.GetNamespace("mapi");
                outlookNameSpace.Logon(Missing.Value, Missing.Value, true, true);
                Outlook.MailItem outlookMessage = (Outlook.MailItem)outlookApplication.CreateItem(Outlook.OlItemType.olMailItem);
                outlookMessage.Subject = subject;
                outlookMessage.BodyFormat = Outlook.OlBodyFormat.olFormatRichText;
                outlookMessage.Body = message;
                outlookMessage.Body = System.Windows.Forms.Clipboard.GetText();
                Outlook.Recipients outlookRecipients = outlookMessage.Recipients;
                String[] recipients;
                if (toRecipients != null)
                {
                    if (toRecipients.Length != 0)
                    {
                        recipients = toRecipients.Replace(" ", "").Split(';');
                        foreach (String recipient in recipients)
                        {
                            if (ExpressionValidator.ExpressionValidator.isEmail(recipient))
                            {
                                Outlook.Recipient outlookRecipientTo = (Outlook.Recipient)outlookRecipients.Add(recipient);
                                outlookRecipientTo.Type = (int)Outlook.OlMailRecipientType.olTo;
                            }
                        }
                    }
                }

                if (toCc!= null)
                {
                    if (toCc.Trim().Length != 0)
                    {
                        recipients = toCc.Replace(" ", "").Split(';');
                        foreach (String recipient in recipients)
                        {
                            if (ExpressionValidator.ExpressionValidator.isEmail(recipient))
                            {
                                Outlook.Recipient outlookRecipientToCc = (Outlook.Recipient)outlookRecipients.Add(recipient);
                                outlookRecipientToCc.Type = (int)Outlook.OlMailRecipientType.olCC;
                            }
                        }
                    }
                }

                if (toCco != null)
                {
                    if (toCco.Trim().Length != 0)
                    {
                        recipients = toCco.Replace(" ", "").Split(';');
                        foreach (String recipient in recipients)
                        {
                            if (ExpressionValidator.ExpressionValidator.isEmail(recipient))
                            {
                                Outlook.Recipient outlookRecipientToCco = (Outlook.Recipient)outlookRecipients.Add(recipient);
                                outlookRecipientToCco.Type = (int)Outlook.OlMailRecipientType.olBCC;
                            }
                        }
                    }
                }                
                outlookRecipients.ResolveAll();

                if (attachmentsSources != null) {
                    if (attachmentsSources.Length!=0) {
                        foreach (String attachment in attachmentsSources) {
                            int attachmentPosition = (int)outlookMessage.Body.Length + 1;
                            int attachmenType = (int)Outlook.OlAttachmentType.olByValue;
                            Outlook.Attachment outlookAttachment = outlookMessage.Attachments.Add(attachment, attachmenType, attachmentPosition, attachment);
                        }
                        outlookMessage.Save();
                    }
                }
                outlookMessage.Display(true);
                //outlookMessage.Send();
                sent = true;
                sent = outlookMessage.Sent;
                //outlookNameSpace.Logoff();
                //outlookRecipients = null;
                //outlookMessage = null;
                //outlookApplication = null;
            }
            catch (Exception ex) {
                if (!ex.Message.Equals("The item has been moved or deleted."))
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            return sent;
        }
    }
}

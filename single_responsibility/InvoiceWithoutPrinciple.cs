using System;
using System.Net.Mail;

namespace single_responsibility.without
{
    public class InvoiceWithoutPrinciple
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public void AddInvoice()
        {
            try
            {
                var mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeleteInvoice()
        {
            try
            {

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}

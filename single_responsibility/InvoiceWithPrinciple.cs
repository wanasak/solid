using System;

namespace single_responsibility.without
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string message, Exception exception);
    }
    public class Logger : ILogger
    {
        public void Error(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }
    }
    public class MailSender
    {
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public void SendEmail() { }
    }
    public class InvoiceWithPrinciple
    {
        private readonly Logger _logger;
        private readonly MailSender _mailSender;

        public InvoiceWithPrinciple()
        {
            _logger = new Logger();
            _mailSender = new MailSender();
        }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public void AddInvoice()
        {
            try
            {
                _logger.Info("Add method Start");
                _mailSender.EmailFrom = "emailfrom@xyz.com";
                _mailSender.EmailTo = "emailto@xyz.com";
                _mailSender.EmailSubject = "Single Responsibility Princile";
                _mailSender.EmailBody = "A class should have only one reason to change";
                _mailSender.SendEmail();
            }
            catch (Exception ex)
            {
                _logger.Error("Error Occurred while Generating Invoice", ex);
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                _logger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                _logger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
}

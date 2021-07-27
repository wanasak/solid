namespace open_closed
{
    public class InvoiceWithoutPrinciple
    {
        public decimal GetInvoiceDiscount(decimal amount, InvoiceType invoiceType)
        {
            decimal finalAmount = 0;

            if (invoiceType == InvoiceType.FinalInvoice)
                finalAmount = amount - 100;
            else if (invoiceType != InvoiceType.ProposedInvoice)
                finalAmount = amount - 50;

            return finalAmount;
        }
    }
    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice
    }
}

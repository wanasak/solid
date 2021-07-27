namespace open_closed
{
    public class Invoice
    {
        public virtual decimal GetInvoiceDiscount(decimal amount)
        {
            return amount - 50;
        }
    }
    public class FinalInvoice : Invoice
    {
        public override decimal GetInvoiceDiscount(decimal amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
    public class ProposedInvoice : Invoice
    {
        public override decimal GetInvoiceDiscount(decimal amount)
        {
            return base.GetInvoiceDiscount(amount) - 20;
        }
    }
    public class RecurringInvoice : Invoice
    {
        public override decimal GetInvoiceDiscount(decimal amount)
        {
            return base.GetInvoiceDiscount(amount) - 10;
        }
    }
}

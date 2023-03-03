namespace PruebaSchad.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustName { get; set; }
        public string Adress { get; set; }
        public string Status { get; set; }
        public int CustomerTypeId { get; set; }
        public virtual CustomerType? CustomerType { get; set; }
        public virtual ICollection<Invoice>? Invoices { get; set; }
        public virtual ICollection<InvoiceDetail>? InvoiceDetails { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PruebaSchad.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int InvoiceDetailId { get; set; }
        public double? TotalItbis { get; set; }
        public double? SubTotal { get; set; }
        public double? Total { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual InvoiceDetail InvoiceDetail { get; set; }

    }
    
}

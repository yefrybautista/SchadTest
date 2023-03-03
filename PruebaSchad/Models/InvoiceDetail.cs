using System.ComponentModel.DataAnnotations;

namespace PruebaSchad.Models
{
    public class InvoiceDetail
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double TotalItbis { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

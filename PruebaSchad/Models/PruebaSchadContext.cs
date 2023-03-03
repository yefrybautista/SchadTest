using Microsoft.EntityFrameworkCore;

namespace PruebaSchad.Models
{
    public class PruebaSchadContext : DbContext
    {
        public PruebaSchadContext(DbContextOptions<PruebaSchadContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasOne(d => d.InvoiceDetail)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
    }
}

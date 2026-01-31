using Microsoft.EntityFrameworkCore;
using BuggyApp.Models;

namespace BuggyApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
    }

    public static class DbSeeder
    {
        public static void Seed(AppDbContext db)
        {
            if (!db.Invoices.Any())
            {
                var invoice = new Invoice { InvoiceID = 1, CustomerName = "John Doe", Items = new List<InvoiceItem>() };
                invoice.Items.Add(new InvoiceItem { ItemID = 1, Name = "Widget A", Price = 19.99m, InvoiceID = 1 });
                db.Invoices.Add(invoice);
                db.SaveChanges();
            }
        }
    }
}
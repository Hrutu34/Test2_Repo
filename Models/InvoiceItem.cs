using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuggyApp.Models
{
    public class InvoiceItem
    {
        [Key]
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public Invoice Invoice { get; set; }
    }
}
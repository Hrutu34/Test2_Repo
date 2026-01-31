using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuggyApp.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; }
        public List<InvoiceItem> Items { get; set; }
    }
}
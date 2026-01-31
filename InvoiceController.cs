
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuggyApp.Data;
using BuggyApp.Models;
using System.Threading.Tasks;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly AppDbContext _db;
        public InvoiceController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> GetInvoice()
        {
            var invoice = await _db.Invoices.Include(i => i.Items).FirstOrDefaultAsync(i => i.InvoiceID == 1);
            if (invoice == null) return NotFound("No invoice found");
            return Ok(invoice);
        }
    }
}

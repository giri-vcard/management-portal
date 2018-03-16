using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ManagementPortal.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagementPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {            
            ViewData["total_account"] = await _context.account.CountAsync(a => a.account_status == 0);
            return View();
        }
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
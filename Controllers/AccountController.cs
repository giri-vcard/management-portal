using System;
using Microsoft.AspNetCore.Mvc;
using ManagementPortal.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ManagementPortal.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;

        public AccountController(DataContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index( 
            string currentFilter,
            string searchString,
            int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            
            ViewData["CurrentFilter"] = searchString;
            
            var accounts = from a in _context.account select a;
            if (!String.IsNullOrEmpty(searchString))
            {
                accounts = accounts.Where(a => a.last_name.ToLower().Contains(searchString.ToLower())
                                               || a.first_name.ToLower().Contains(searchString.ToLower())
                                               || a.vcard_id.ToLower().Contains(searchString.ToLower()));
            }
            
            int pageSize = 10;
            return View(await PaginatedList<Account>.CreateAsync(accounts.AsNoTracking(), page ?? 1, pageSize));
        }
        
        
        // GET: Account/Details/be3b9cae-8dcb-40b8-8c90-2ddceb5ba986
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.account
                .Include(a => a.account_subscription)
                .AsNoTracking()
                .SingleOrDefaultAsync(m => m.account_id == id);

            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }
        
    }
}
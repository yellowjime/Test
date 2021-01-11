using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models.DB;
using Microsoft.EntityFrameworkCore;
namespace WebApplication5.Controllers
{

    public class HomeController : Controller
    {
        private readonly Context context;
        public HomeController(Context _context)
        {
            context = _context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await context.Employee.ToListAsync());
        }
    }
}

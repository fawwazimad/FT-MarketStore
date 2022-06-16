using FT_MarketStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FT_MarketStore.Controllers
{
    public class AdminController : Controller
    {
        private readonly ModelContext _context;

        public AdminController(ModelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }
        public IActionResult Products()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }

        public IActionResult Accounts()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }

        public IActionResult Add_Products()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add_Products([Bind("ProductName,ProductInfo,ExDate,ProductId, ImagePath")] Product product)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }


        public IActionResult Edit_Products()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }

        [HttpGet]
        public IActionResult Search()
        {
            var modelContext = _context.ProductCarts.ToList();

            return View(modelContext);
        }
        [HttpPost]
        public async Task<IActionResult> Search(DateTime? stratDate, DateTime? endDate)
        {

            //var modelContext = _context.ProductCarts;
            //if (stratDate == null && endDate == null)
            //{
            //    return View(modelContext);
            //}
            //else if (stratDate == null && endDate != null)
            //{
            //    var result = await modelContext.Where(x => x.DateFrom.Value.Date == endDate).ToListAsync();
            //    return View(result);
            //}
            //else if (stratDate != null && endDate == null)
            //{
            //    var result = await modelContext.Where(x => x.DateFrom.Value.Date == startDate).ToListAsync();
            //    return View(result);
            //}
            //else
            //{
            //    var result = await modelContext.Where(x => x.DateFrom.Value.Date >= startDate && x.DateFrom.Value.Date <= endDate).ToListAsync();
            //    return View(result);
            //}
            return View();
        }



    }
}

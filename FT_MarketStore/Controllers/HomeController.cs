using FT_MarketStore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FT_MarketStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModelContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ModelContext context, IWebHostEnvironment webHostEnviroment)
        {
            _logger = logger;
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }

        public async Task<IActionResult> IndexAsync()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            ViewBag.userName = HttpContext.Session.GetString("userName");
            return View(await _context.Categories.ToListAsync());
        }


        public IActionResult Stores(decimal id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            var categoryStore = _context.Stores.Where(x => x.CategoryId == id);
            return View(categoryStore);
        }

        public IActionResult Products(decimal id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            var ProductStore = _context.Products.Where(y => y.StoreId == id);
            return View(ProductStore);
        }
        public IActionResult AboutUs()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }

        public IActionResult Services()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }
        public IActionResult Blog()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }
        public IActionResult ContactUs()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }




        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn([Bind("Email,Passwordd")] UserLogin userLogin)
        {
            var auth = _context.UserLogins.Include(x=>x.User).Where(x => x.Email == userLogin.Email && x.Passwordd == userLogin.Passwordd).SingleOrDefault();

            if (auth != null)
            {
                switch (auth.RoleId)
                {
                    case 1:
                        {
                            HttpContext.Session.SetInt32("RoleId", (int)auth.RoleId);
                            HttpContext.Session.SetInt32("userId", (int)auth.UserId);
                            HttpContext.Session.SetString("userName", auth.User.Fname);
                            return RedirectToAction("Index", "Home"); 
                        }
                    case 2:
                        { 
                        HttpContext.Session.SetInt32("RoleId", (int)auth.RoleId);
                        HttpContext.Session.SetInt32("userId", (int)auth.UserId);
                            HttpContext.Session.SetString("userName", auth.User.Fname);
                            return RedirectToAction("Index", "Admin");
                        }
                }

            }
            return View();
        }
        
        
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([Bind("Userid,Fname,Lname")] Userr user, string email, string password)
        {
            if (ModelState.IsValid)
            {
               
                string w3rootpath = _webHostEnviroment.WebRootPath;
                var lastId = _context.Userrs.OrderByDescending(p => p.UserId).FirstOrDefault().UserId;

                UserLogin userLogin = new Models.UserLogin();
                userLogin.RoleId = 1;  
                userLogin.UserId = lastId; 
                userLogin.Email = email; 
                userLogin.Passwordd = password; 
                _context.Add(userLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction("SignIn", "Home");
            }
            return View(user);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Details(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Userrs
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        public async Task<IActionResult> Edit(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Userrs.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("UserId,Fname,Lname,UserBalance")] Userr user)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Remove("RoleId");
            HttpContext.Session.Remove("userId");
            HttpContext.Session.Clear();

            return RedirectToAction("SignIn", "Home");
        }



    }
}

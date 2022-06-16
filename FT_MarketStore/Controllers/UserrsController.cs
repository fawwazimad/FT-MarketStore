using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FT_MarketStore.Models;
using Microsoft.AspNetCore.Http;

namespace FT_MarketStore.Controllers
{
    public class UserrsController : Controller
    {
        private readonly ModelContext _context;

        public UserrsController(ModelContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()

        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View(await _context.Userrs.ToListAsync());
        }

        // GET: Customers/Details/5
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

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Userid,Fname,Lname,UserBalance")] Userr user)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Customers/Edit/5
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
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Userrs
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            var customer = await _context.Userrs.FindAsync(id);
            _context.Userrs.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(decimal id)
        {
            return _context.Userrs.Any(e => e.UserId == id);
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

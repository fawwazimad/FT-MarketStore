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
    public class StoresController : Controller
    {
        private readonly ModelContext _context;

        public StoresController(ModelContext context)
        {
            _context = context;
        }

        // GET: Stores
        public async Task<IActionResult> Index()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            var modelContext = _context.Stores.Include(s => s.Category);
            return View(await modelContext.ToListAsync());
        }

        // GET: Stores/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var store = await _context.Stores
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.StoreId == id);
            if (store == null)
            {
                return NotFound();
            }

            return View(store);
        }

        // GET: Stores/Create
        public IActionResult Create()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Stores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoreId,StoreName,StoreImage,StorePhone,StoreEmail,StoreCity,StoreInfo,CategoryId")] Store store)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (ModelState.IsValid)
            {
                _context.Add(store);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", store.CategoryId);
            return View(store);
        }

        // GET: Stores/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var store = await _context.Stores.FindAsync(id);
            if (store == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", store.CategoryId);
            return View(store);
        }

        // POST: Stores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("StoreId,StoreName,StoreImage,StorePhone,StoreEmail,StoreCity,StoreInfo,CategoryId")] Store store)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id != store.StoreId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(store);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoreExists(store.StoreId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", store.CategoryId);
            return View(store);
        }

        // GET: Stores/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var store = await _context.Stores
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.StoreId == id);
            if (store == null)
            {
                return NotFound();
            }

            return View(store);
        }

        // POST: Stores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            var store = await _context.Stores.FindAsync(id);
            _context.Stores.Remove(store);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoreExists(decimal id)
        {
            return _context.Stores.Any(e => e.StoreId == id);
        }
    }
}

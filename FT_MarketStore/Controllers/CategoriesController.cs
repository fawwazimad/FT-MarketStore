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
    public class CategoriesController : Controller
    {
        private readonly ModelContext _context;

        public CategoriesController(ModelContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName,ImagePath")] Category category)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CategoryId,CategoryName,ImagePath")] Category category)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
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
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            ViewBag.RoleId = HttpContext.Session.GetInt32("RoleId");
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(decimal id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}

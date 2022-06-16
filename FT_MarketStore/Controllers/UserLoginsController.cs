using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FT_MarketStore.Models;

namespace FT_MarketStore.Controllers
{
    public class UserLoginsController : Controller
    {
        private readonly ModelContext _context;

        public UserLoginsController(ModelContext context)
        {
            _context = context;
        }

        // GET: UserLogins
        public async Task<IActionResult> Index()
        {
            var modelContext = _context.UserLogins.Include(u => u.User).Include(u => u.Role);
            return View(await modelContext.ToListAsync());
        }

        // GET: UserLogins/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogin = await _context.UserLogins
                .Include(u => u.User)
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.LoginId == id);
            if (userLogin == null)
            {
                return NotFound();
            }

            return View(userLogin);
        }

        // GET: UserLogins/Create
        public IActionResult Create()
        {
            ViewData["Userid"] = new SelectList(_context.Userrs, "Userid", "Userid");
            ViewData["RoleId"] = new SelectList(_context.Rolees, "RoleId", "RoleName");
            return View();
        }

        // POST: UserLogins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoginId,Email,Passwordd,Userid,RoleId")] UserLogin userLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Userid"] = new SelectList(_context.Userrs, "Userid", "Userid", userLogin.UserId);
            ViewData["RoleId"] = new SelectList(_context.Rolees, "RoleId", "RoleId", userLogin.RoleId);
            return View(userLogin);
        }

        // GET: UserLogins/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogin = await _context.UserLogins.FindAsync(id);
            if (userLogin == null)
            {
                return NotFound();
            }
            ViewData["Userid"] = new SelectList(_context.Userrs, "Userid", "UserName", userLogin.UserId);
            ViewData["RoleId"] = new SelectList(_context.Rolees, "RoleId", "RoleId", userLogin.RoleId);
            return View(userLogin);
        }

        // POST: UserLogins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("LoginId,Email,Passwordd,Userid,RoleId")] UserLogin userLogin)
        {
            if (id != userLogin.LoginId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userLogin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserLoginExists(userLogin.LoginId))
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
            ViewData["Userid"] = new SelectList(_context.Userrs, "Userid", "Userid", userLogin.UserId);
            ViewData["RoleId"] = new SelectList(_context.Rolees, "RoleId", "RoleId", userLogin.RoleId);
            return View(userLogin);
        }

        // GET: UserLogins/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userLogin = await _context.UserLogins
                .Include(u => u.User)
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.LoginId == id);
            if (userLogin == null)
            {
                return NotFound();
            }

            return View(userLogin);
        }

        // POST: UserLogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var userLogin = await _context.UserLogins.FindAsync(id);
            _context.UserLogins.Remove(userLogin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserLoginExists(decimal id)
        {
            return _context.UserLogins.Any(e => e.LoginId == id);
        }
    }
}

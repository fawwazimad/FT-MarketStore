using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FT_MarketStore.Models;
using Microsoft.AspNetCore.Http;
using MimeKit; 
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace FT_MarketStore.Controllers
{
    public class CartsController : Controller
    { 
        private readonly ModelContext _context;
 

        public CartsController(ModelContext context)
        {
            _context = context;
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {

            var modelContext = _context.Carts.Include(c => c.ProductCarts).Include(c => c.User);
            return View(await modelContext.ToListAsync());
        }

        // GET: Carts/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.ProductCarts)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CardId == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId");
            ViewData["Userid"] = new SelectList(_context.Userrs, "UserId", "UserId");
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CardId,Userid,Quantity,TotalPrice,OrderDate,ProductId")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Userid"] = new SelectList(_context.Userrs, "UserId", "UserId", cart.Userid);
            return View(cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            } 
            ViewData["Userid"] = new SelectList(_context.Userrs, "UserId", "UserId", cart.Userid);
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CardId,Userid,Quantity,TotalPrice,OrderDate,ProductId")] Cart cart)
        {
            if (id != cart.CardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.CardId))
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
            ViewData["Userid"] = new SelectList(_context.Userrs, "UserId", "UserId", cart.Userid);
            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.ProductCarts)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CardId == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var cart = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(decimal id)
        {
            return _context.Carts.Any(e => e.CardId == id);
        }

        static List<decimal> ss = new List<decimal>();
        static List<Product> products = new List<Product>();

        
        public bool addtolist(decimal id)
        {
            ss.Add(id);
            return true;
        }


       
        public async Task<IActionResult> Cart()
        {
            var userId = HttpContext.Session.GetInt32("userId");
            var productsId = ss;
            for (int i = 0; i < productsId.Count; i++)
            {
                products.Add(_context.Products.Where(p => p.ProductId == productsId[i]).Single()); 
            } 
            
            Cart newCart = await _context.Carts.FirstOrDefaultAsync(c => c.Userid == userId);
            if (newCart == null)
            {
                newCart = new Cart();
                newCart.Userid = userId;
                newCart.TotalPrice = 0;
                _context.Add(newCart);
                await _context.SaveChangesAsync();
            }
            for (int i = 0; i < products.Count; i++)
            {
                newCart.TotalPrice += products[i].ProductPrice;
            }
            ProductCart pc;
            for (int i = 0; i < productsId.Count; i++)
            {
                pc = new ProductCart();
                pc.ProductId = productsId[i];
                pc.CartId = newCart.CardId;
                _context.Add(pc);
                await _context.SaveChangesAsync();
            }

            ss.Clear();
            return View(newCart.ProductCarts);

        }

        public async Task<IActionResult> ThankYouAsync(decimal value)
        {

            var userId = HttpContext.Session.GetInt32("userId");
            Userr user = await _context.Userrs.FirstOrDefaultAsync(c => c.UserId == userId);
            Cart newCart = await _context.Carts.FirstOrDefaultAsync(c => c.Userid == userId);

            user.UserBalance -= value; 
            newCart.ProductCarts.Clear();
            await _context.SaveChangesAsync();
            return View();
        }
        
        public IActionResult CheckoutAsync()
        {
            return View(products);
        }


        public void sendemail()
        {  }
        [HttpPost]
        public void sendemail(string to,string body)
        {
            // var fii = new IFormFile();
            //if (HttpContext.Request.Form.Files.Count != 0)
            //{
            //   var fii = HttpContext.Request.Form.Files[0];
               // byte[] b;
               // using (BinaryReader br = new BinaryReader(fii.OpenReadStream()))
               // {
               //     b = br.ReadBytes((int)fii.OpenReadStream().Length);

               // }
               //// var stream = new MemoryStream(b);
               // var downloadUrl = Convert.ToBase64String(b);

                MimeMessage obj = new MimeMessage();
                MailboxAddress emailfrom = new MailboxAddress("FT Store", "ftstoree2022@gmail.com");
                MailboxAddress emailto = new MailboxAddress("user", to);
                obj.From.Add(emailfrom);
                obj.To.Add(emailto);
                obj.Subject = "Thank You for using FT Store"; 
                BodyBuilder bb = new BodyBuilder();
                bb.HtmlBody = "<html>" + "<h1>" + body + "</h1>" + "</html>";
                obj.Body = bb.ToMessageBody();
                SmtpClient emailclient = new SmtpClient();
                emailclient.Connect("smtp.gmail.com", 465, true);
                emailclient.Authenticate("ftstoree2022@gmail.com", "Ftstore12345");
                emailclient.Send(obj);
                emailclient.Disconnect(true);
                emailclient.Dispose();
            
            RedirectToAction("Checkout", "Carts"); 
        }
    }
}

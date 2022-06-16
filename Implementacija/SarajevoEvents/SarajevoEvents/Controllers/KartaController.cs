using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SarajevoEvents.Models;

namespace SarajevoEvents.Controllers
{
    public class KartaController : Controller
    {
        private readonly ApplicationDataContext _context;

        public KartaController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: Karta
        public async Task<IActionResult> Index()
        {
            var applicationDataContext = _context.Karta.Include(k => k.RegistrovaniKorisnik);
            return View(await applicationDataContext.ToListAsync());
        }

        // GET: Karta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Karta == null)
            {
                return NotFound();
            }

            var karta = await _context.Karta
                .Include(k => k.RegistrovaniKorisnik)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (karta == null)
            {
                return NotFound();
            }

            return View(karta);
        }

        // GET: Karta/Create
        public IActionResult Create()
        {
            ViewData["IDRegistrovaniKorisnik"] = new SelectList(_context.RegistrovaniKorisnik, "ID", "ID");
            return View();
        }

        // POST: Karta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IDDogadjaj,IDRegistrovaniKorisnik,IDPlacanje,cijena")] Karta karta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(karta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDRegistrovaniKorisnik"] = new SelectList(_context.RegistrovaniKorisnik, "ID", "ID", karta.IDRegistrovaniKorisnik);
            return View(karta);
        }

        // GET: Karta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Karta == null)
            {
                return NotFound();
            }

            var karta = await _context.Karta.FindAsync(id);
            if (karta == null)
            {
                return NotFound();
            }
            ViewData["IDRegistrovaniKorisnik"] = new SelectList(_context.RegistrovaniKorisnik, "ID", "ID", karta.IDRegistrovaniKorisnik);
            return View(karta);
        }

        // POST: Karta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IDDogadjaj,IDRegistrovaniKorisnik,IDPlacanje,cijena")] Karta karta)
        {
            if (id != karta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(karta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KartaExists(karta.ID))
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
            ViewData["IDRegistrovaniKorisnik"] = new SelectList(_context.RegistrovaniKorisnik, "ID", "ID", karta.IDRegistrovaniKorisnik);
            return View(karta);
        }

        // GET: Karta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Karta == null)
            {
                return NotFound();
            }

            var karta = await _context.Karta
                .Include(k => k.RegistrovaniKorisnik)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (karta == null)
            {
                return NotFound();
            }

            return View(karta);
        }

        // POST: Karta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Karta == null)
            {
                return Problem("Entity set 'ApplicationDataContext.Karta'  is null.");
            }
            var karta = await _context.Karta.FindAsync(id);
            if (karta != null)
            {
                _context.Karta.Remove(karta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KartaExists(int id)
        {
          return (_context.Karta?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

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
    public class DogadjajController : Controller
    {
        private Random rnd = new Random();
        private readonly ApplicationDataContext _context;

        public DogadjajController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: Dogadjaj
        public async Task<IActionResult> Index()
        {
            ViewData["rnd"] = rnd;
            var applicationDataContext = _context.Dogadjaj.Include(d => d.PoslovniKorisnik);
            return View(await applicationDataContext.ToListAsync());
        }

        // GET: Dogadjaj/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Dogadjaj == null)
            {
                return NotFound();
            }

            var dogadjaj = await _context.Dogadjaj
                .Include(d => d.PoslovniKorisnik)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dogadjaj == null)
            {
                return NotFound();
            }

            return View(dogadjaj);
        }

        // GET: Dogadjaj/Create
        public IActionResult Create()
        {
            ViewData["IDPoslovniKorisnik"] = new SelectList(_context.PoslovniKorisnik, "ID", "ID");
            return View();
        }

        // POST: Dogadjaj/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,datumOdrzavanja,vrstaDogadjaja,potrebnaKarta,cijenaKarte,potrebnaRezervacija,brojNagradnihBodova,IDPoslovniKorisnik")] Dogadjaj dogadjaj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dogadjaj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDPoslovniKorisnik"] = new SelectList(_context.PoslovniKorisnik, "ID", "ID", dogadjaj.IDPoslovniKorisnik);
            return View(dogadjaj);
        }

        // GET: Dogadjaj/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dogadjaj == null)
            {
                return NotFound();
            }

            var dogadjaj = await _context.Dogadjaj.FindAsync(id);
            if (dogadjaj == null)
            {
                return NotFound();
            }
            ViewData["IDPoslovniKorisnik"] = new SelectList(_context.PoslovniKorisnik, "ID", "ID", dogadjaj.IDPoslovniKorisnik);
            return View(dogadjaj);
        }

        // POST: Dogadjaj/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,datumOdrzavanja,vrstaDogadjaja,potrebnaKarta,cijenaKarte,potrebnaRezervacija,brojNagradnihBodova,IDPoslovniKorisnik")] Dogadjaj dogadjaj)
        {
            if (id != dogadjaj.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dogadjaj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogadjajExists(dogadjaj.ID))
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
            ViewData["IDPoslovniKorisnik"] = new SelectList(_context.PoslovniKorisnik, "ID", "ID", dogadjaj.IDPoslovniKorisnik);
            return View(dogadjaj);
        }

        // GET: Dogadjaj/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dogadjaj == null)
            {
                return NotFound();
            }

            var dogadjaj = await _context.Dogadjaj
                .Include(d => d.PoslovniKorisnik)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dogadjaj == null)
            {
                return NotFound();
            }

            return View(dogadjaj);
        }

        // POST: Dogadjaj/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dogadjaj == null)
            {
                return Problem("Entity set 'ApplicationDataContext.Dogadjaj'  is null.");
            }
            var dogadjaj = await _context.Dogadjaj.FindAsync(id);
            if (dogadjaj != null)
            {
                _context.Dogadjaj.Remove(dogadjaj);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogadjajExists(int id)
        {
            return (_context.Dogadjaj?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

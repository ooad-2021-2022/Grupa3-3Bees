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
    public class PoslovniKorisnikController : Controller
    {
        private readonly ApplicationDataContext _context;

        public PoslovniKorisnikController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: PoslovniKorisnik
        public async Task<IActionResult> Index()
        {
              return _context.PoslovniKorisnik != null ? 
                          View(await _context.PoslovniKorisnik.ToListAsync()) :
                          Problem("Entity set 'ApplicationDataContext.PoslovniKorisnik'  is null.");
        }

        // GET: PoslovniKorisnik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PoslovniKorisnik == null)
            {
                return NotFound();
            }

            var poslovniKorisnik = await _context.PoslovniKorisnik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (poslovniKorisnik == null)
            {
                return NotFound();
            }

            return View(poslovniKorisnik);
        }

        // GET: PoslovniKorisnik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PoslovniKorisnik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("nazivKorisnika,brojNagradnihBodova,ID,email,ime,prezime,userName,brojTelefona,lozinka")] PoslovniKorisnik poslovniKorisnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(poslovniKorisnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poslovniKorisnik);
        }

        // GET: PoslovniKorisnik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PoslovniKorisnik == null)
            {
                return NotFound();
            }

            var poslovniKorisnik = await _context.PoslovniKorisnik.FindAsync(id);
            if (poslovniKorisnik == null)
            {
                return NotFound();
            }
            return View(poslovniKorisnik);
        }

        // POST: PoslovniKorisnik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("nazivKorisnika,brojNagradnihBodova,ID,email,ime,prezime,userName,brojTelefona,lozinka")] PoslovniKorisnik poslovniKorisnik)
        {
            if (id != poslovniKorisnik.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poslovniKorisnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PoslovniKorisnikExists(poslovniKorisnik.ID))
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
            return View(poslovniKorisnik);
        }

        // GET: PoslovniKorisnik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PoslovniKorisnik == null)
            {
                return NotFound();
            }

            var poslovniKorisnik = await _context.PoslovniKorisnik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (poslovniKorisnik == null)
            {
                return NotFound();
            }

            return View(poslovniKorisnik);
        }

        // POST: PoslovniKorisnik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PoslovniKorisnik == null)
            {
                return Problem("Entity set 'ApplicationDataContext.PoslovniKorisnik'  is null.");
            }
            var poslovniKorisnik = await _context.PoslovniKorisnik.FindAsync(id);
            if (poslovniKorisnik != null)
            {
                _context.PoslovniKorisnik.Remove(poslovniKorisnik);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PoslovniKorisnikExists(int id)
        {
          return (_context.PoslovniKorisnik?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

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
    public class RegistrovaniKorisnikController : Controller
    {
        private readonly ApplicationDataContext _context;

        public RegistrovaniKorisnikController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: RegistrovaniKorisnik
        public async Task<IActionResult> Index()
        {
              return _context.RegistrovaniKorisnik != null ? 
                          View(await _context.RegistrovaniKorisnik.ToListAsync()) :
                          Problem("Entity set 'ApplicationDataContext.RegistrovaniKorisnik'  is null.");
        }

        // GET: RegistrovaniKorisnik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RegistrovaniKorisnik == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }

            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisnik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistrovaniKorisnik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("nazivKorisnika,ID,email,ime,prezime,userName,brojTelefona,lozinka")] RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrovaniKorisnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisnik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RegistrovaniKorisnik == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik.FindAsync(id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }
            return View(registrovaniKorisnik);
        }

        // POST: RegistrovaniKorisnik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("nazivKorisnika,ID,email,ime,prezime,userName,brojTelefona,lozinka")] RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (id != registrovaniKorisnik.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrovaniKorisnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrovaniKorisnikExists(registrovaniKorisnik.ID))
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
            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisnik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RegistrovaniKorisnik == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }

            return View(registrovaniKorisnik);
        }

        // POST: RegistrovaniKorisnik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RegistrovaniKorisnik == null)
            {
                return Problem("Entity set 'ApplicationDataContext.RegistrovaniKorisnik'  is null.");
            }
            var registrovaniKorisnik = await _context.RegistrovaniKorisnik.FindAsync(id);
            if (registrovaniKorisnik != null)
            {
                _context.RegistrovaniKorisnik.Remove(registrovaniKorisnik);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrovaniKorisnikExists(int id)
        {
          return (_context.RegistrovaniKorisnik?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

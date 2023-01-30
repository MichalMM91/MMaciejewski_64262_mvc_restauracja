using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MMaciejewski_64262_mvc_restauracja.Data;
using MMaciejewski_64262_mvc_restauracja.Models;

namespace MMaciejewski_64262_mvc_restauracja.Controllers
{
    public class AdminController : Controller
    {
        private readonly ProjectContext _context;

        public AdminController(ProjectContext context)
        {
            _context = context;
        }

        // GET: Dania
        public async Task<IActionResult> Index(string searchString)
        {
            var dania = from m in _context.Danie
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                dania = dania.Where(s => s.Nazwa!.Contains(searchString));
            }

            return View(await dania.ToListAsync());

        }

        // GET: Dania/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Danie == null)
            {
                return NotFound();
            }

            var danie = await _context.Danie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (danie == null)
            {
                return NotFound();
            }

            return View(danie);
        }

        // GET: Dania/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dania/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nazwa,Kategoria,Dieta,Ilość,Cena")] Danie danie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(danie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(danie);
        }

        // GET: Dania/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Danie == null)
            {
                return NotFound();
            }

            var danie = await _context.Danie.FindAsync(id);
            if (danie == null)
            {
                return NotFound();
            }
            return View(danie);
        }

        // POST: Dania/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nazwa,Kategoria,Dieta,Ilość,Cena")] Danie danie)
        {
            if (id != danie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(danie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DanieExists(danie.Id))
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
            return View(danie);
        }

        // GET: Dania/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Danie == null)
            {
                return NotFound();
            }

            var danie = await _context.Danie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (danie == null)
            {
                return NotFound();
            }

            return View(danie);
        }

        // POST: Dania/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Danie == null)
            {
                return Problem("Entity set 'ProjectContext.Danie'  is null.");
            }
            var danie = await _context.Danie.FindAsync(id);
            if (danie != null)
            {
                _context.Danie.Remove(danie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DanieExists(int id)
        {
            return _context.Danie.Any(e => e.Id == id);
        }
    }
}

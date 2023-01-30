using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MMaciejewski_64262_mvc_restauracja.Data;
using MMaciejewski_64262_mvc_restauracja.Models;

namespace MMaciejewski_64262_mvc_restauracja.Controllers
{
    public class DaniaController : Controller
    {
        private readonly ProjectContext _context;

        public DaniaController(ProjectContext context)
        {
            _context = context;
        }

        // GET: Dania
        public async Task<IActionResult> Index(string dietaDania, string searchString)
        {
            // Use LINQ to get list of diety's.
            IQueryable<string> dietaKwerenda = from m in _context.Danie
                                            orderby m.Dieta
                                            select m.Dieta;

            var dania = from m in _context.Danie
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                dania = dania.Where(s => s.Nazwa!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(dietaDania))
            {
                dania = dania.Where(x => x.Dieta == dietaDania);
            }

            var movieGenreVM = new ModelWyboruDiety
            {
                Diety = new SelectList(await dietaKwerenda.Distinct().ToListAsync()),
                Dania = await dania.ToListAsync()
            };

            return View(movieGenreVM);

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

        private bool DanieExists(int id)
        {
          return _context.Danie.Any(e => e.Id == id);
        }
    }
    
}

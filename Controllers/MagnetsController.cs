using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Magnets.Data;
using Magnets.Models;

namespace Magnets.Controllers
{
    public class MagnetsController : Controller
    {
        private readonly MagnetsContext _context;

        public MagnetsController(MagnetsContext context)
        {
            _context = context;
        }

        // GET: Magnets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Magnet.ToListAsync());
        }

        // GET: Magnets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magnet = await _context.Magnet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (magnet == null)
            {
                return NotFound();
            }

            return View(magnet);
        }

        // GET: Magnets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Magnets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MagnetNames,Material,Applications,Strength,Rating,Price")] Magnet magnet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(magnet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(magnet);
        }

        // GET: Magnets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magnet = await _context.Magnet.FindAsync(id);
            if (magnet == null)
            {
                return NotFound();
            }
            return View(magnet);
        }

        // POST: Magnets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MagnetNames,Material,Applications,Strength,Rating,Price")] Magnet magnet)
        {
            if (id != magnet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(magnet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MagnetExists(magnet.Id))
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
            return View(magnet);
        }

        // GET: Magnets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var magnet = await _context.Magnet
                .FirstOrDefaultAsync(m => m.Id == id);
            if (magnet == null)
            {
                return NotFound();
            }

            return View(magnet);
        }

        // POST: Magnets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var magnet = await _context.Magnet.FindAsync(id);
            _context.Magnet.Remove(magnet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MagnetExists(int id)
        {
            return _context.Magnet.Any(e => e.Id == id);
        }
    }
}

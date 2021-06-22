using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Models;
using Data;

namespace Bittirme.Controllers
{
    public class UrunlersController : Controller
    {
        private readonly E_TicaretContext _context;

        public UrunlersController(E_TicaretContext context)
        {
            _context = context;
        }

        // GET: Urunlers
        public async Task<IActionResult> Index()
        {
            var e_TicaretContext = _context.TblUrunlers.Include(u => u.mouse);
            return View(await e_TicaretContext.ToListAsync());
        }

        // GET: Urunlers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urunler = await _context.TblUrunlers
                .Include(u => u.mouse)
                .FirstOrDefaultAsync(m => m.UrunId == id);
            if (urunler == null)
            {
                return NotFound();
            }

            return View(urunler);
        }

        // GET: Urunlers/Create
        public IActionResult Create()
        {
            ViewData["mouseId"] = new SelectList(_context.mouse, "mouseId", "mouseId");
            return View();
        }

        // POST: Urunlers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UrunId,ramıd,ssdıd,mouseId,ekrankartııd")] Urunler urunler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(urunler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["mouseId"] = new SelectList(_context.mouse, "mouseId", "mouseId", urunler.mouseId);
            return View(urunler);
        }

        // GET: Urunlers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urunler = await _context.TblUrunlers.FindAsync(id);
            if (urunler == null)
            {
                return NotFound();
            }
            ViewData["mouseId"] = new SelectList(_context.mouse, "mouseId", "mouseId", urunler.mouseId);
            return View(urunler);
        }

        // POST: Urunlers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UrunId,ramıd,ssdıd,mouseId,ekrankartııd")] Urunler urunler)
        {
            if (id != urunler.UrunId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(urunler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UrunlerExists(urunler.UrunId))
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
            ViewData["mouseId"] = new SelectList(_context.mouse, "mouseId", "mouseId", urunler.mouseId);
            return View(urunler);
        }

        // GET: Urunlers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urunler = await _context.TblUrunlers
                .Include(u => u.mouse)
                .FirstOrDefaultAsync(m => m.UrunId == id);
            if (urunler == null)
            {
                return NotFound();
            }

            return View(urunler);
        }

        // POST: Urunlers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var urunler = await _context.TblUrunlers.FindAsync(id);
            _context.TblUrunlers.Remove(urunler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UrunlerExists(int id)
        {
            return _context.TblUrunlers.Any(e => e.UrunId == id);
        }
    }
}

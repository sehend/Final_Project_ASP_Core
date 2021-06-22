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
    public class TblMusterisController : Controller
    {
        private readonly E_TicaretContext _context;

        public TblMusterisController(E_TicaretContext context)
        {
            _context = context;
        }

        // GET: TblMusteris
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblMusteris.ToListAsync());
        }

        // GET: TblMusteris/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMusteri = await _context.TblMusteris
                .FirstOrDefaultAsync(m => m.Müşıd == id);
            if (tblMusteri == null)
            {
                return NotFound();
            }

            return View(tblMusteri);
        }

        // GET: TblMusteris/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblMusteris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Müşıd,Ad,Soyad,Adress,Tc,Tel,Email,Urunıd")] TblMusteri tblMusteri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblMusteri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(tblMusteri);
        }

        // GET: TblMusteris/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMusteri = await _context.TblMusteris.FindAsync(id);
            if (tblMusteri == null)
            {
                return NotFound();
            }
            return View(tblMusteri);
        }

        // POST: TblMusteris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Müşıd,Ad,Soyad,Adress,Tc,Tel,Email,Urunıd")] TblMusteri tblMusteri)
        {
            if (id != tblMusteri.Müşıd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblMusteri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblMusteriExists(tblMusteri.Müşıd))
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
            return View(tblMusteri);
        }

        // GET: TblMusteris/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMusteri = await _context.TblMusteris
                .FirstOrDefaultAsync(m => m.Müşıd == id);
            if (tblMusteri == null)
            {
                return NotFound();
            }

            return View(tblMusteri);
        }

        // POST: TblMusteris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblMusteri = await _context.TblMusteris.FindAsync(id);
            _context.TblMusteris.Remove(tblMusteri);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblMusteriExists(int id)
        {
            return _context.TblMusteris.Any(e => e.Müşıd == id);
        }
    }
}

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
    public class TblSatisController : Controller
    {
        private readonly E_TicaretContext _context;

        public TblSatisController(E_TicaretContext context)
        {
            _context = context;
        }

        // GET: TblSatis
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblSatis.ToListAsync());
        }

        // GET: TblSatis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSati = await _context.TblSatis
                .FirstOrDefaultAsync(m => m.KardId == id);
            if (tblSati == null)
            {
                return NotFound();
            }

            return View(tblSati);
        }

        // GET: TblSatis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblSatis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KardId,Ad,Soyad,KartNo,SonKulanma,Cvv")] TblSati tblSati)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblSati);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(tblSati);
        }

        // GET: TblSatis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSati = await _context.TblSatis.FindAsync(id);
            if (tblSati == null)
            {
                return NotFound();
            }
            return View(tblSati);
        }

        // POST: TblSatis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KardId,Ad,Soyad,KartNo,SonKulanma,Cvv")] TblSati tblSati)
        {
            if (id != tblSati.KardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblSati);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblSatiExists(tblSati.KardId))
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
            return View(tblSati);
        }

        // GET: TblSatis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSati = await _context.TblSatis
                .FirstOrDefaultAsync(m => m.KardId == id);
            if (tblSati == null)
            {
                return NotFound();
            }

            return View(tblSati);
        }

        // POST: TblSatis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblSati = await _context.TblSatis.FindAsync(id);
            _context.TblSatis.Remove(tblSati);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblSatiExists(int id)
        {
            return _context.TblSatis.Any(e => e.KardId == id);
        }
    }
}

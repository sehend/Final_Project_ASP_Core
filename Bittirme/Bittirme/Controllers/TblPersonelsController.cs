using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Models;
using Data;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Bittirme.Controllers
{
    public class TblPersonelsController : Controller
    {
        private readonly E_TicaretContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public TblPersonelsController(E_TicaretContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: TblPersonels
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblPersonels.ToListAsync());
        }

        // GET: TblPersonels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPersonel = await _context.TblPersonels
                .FirstOrDefaultAsync(m => m.Personelıd == id);
            if (tblPersonel == null)
            {
                return NotFound();
            }

            return View(tblPersonel);
        }

        // GET: TblPersonels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblPersonels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Personelıd,imageFile,Ad,Soyad,Tc,Adress,Tel,Email,PersonelMaas,Müdürıd,Kategoriıd")] TblPersonel tblPersonel)
        {
            if (ModelState.IsValid)
            {
                string wwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(tblPersonel.imageFile.FileName);
                string extention = Path.GetExtension(tblPersonel.imageFile.FileName);
                tblPersonel.imageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extention;
                string path = Path.Combine(wwRootPath + "/image/Personel/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await tblPersonel.imageFile.CopyToAsync(fileStream);
                }

                _context.Add(tblPersonel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblPersonel);
        }

        // GET: TblPersonels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPersonel = await _context.TblPersonels.FindAsync(id);
            if (tblPersonel == null)
            {
                return NotFound();
            }
            return View(tblPersonel);
        }

        // POST: TblPersonels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Personelıd,imageName,Ad,Soyad,Tc,Adress,Tel,Email,PersonelMaas,Müdürıd,Kategoriıd")] TblPersonel tblPersonel)
        {
            if (id != tblPersonel.Personelıd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblPersonel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblPersonelExists(tblPersonel.Personelıd))
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
            return View(tblPersonel);
        }

        // GET: TblPersonels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPersonel = await _context.TblPersonels
                .FirstOrDefaultAsync(m => m.Personelıd == id);
            if (tblPersonel == null)
            {
                return NotFound();
            }

            return View(tblPersonel);
        }

        // POST: TblPersonels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblPersonel = await _context.TblPersonels.FindAsync(id);
            _context.TblPersonels.Remove(tblPersonel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblPersonelExists(int id)
        {
            return _context.TblPersonels.Any(e => e.Personelıd == id);
        }
    }
}

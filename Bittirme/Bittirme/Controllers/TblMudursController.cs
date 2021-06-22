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
    public class TblMudursController : Controller
    {
        private readonly E_TicaretContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public TblMudursController(E_TicaretContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: TblMudurs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblMudurs.ToListAsync());
        }

        // GET: TblMudurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMudur = await _context.TblMudurs
                .FirstOrDefaultAsync(m => m.Müdürıd == id);
            if (tblMudur == null)
            {
                return NotFound();
            }

            return View(tblMudur);
        }

        // GET: TblMudurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblMudurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Müdürıd,imageFile,Ad,Soyad,Tc,Adress,Tel,Email,MüdürMaaş,Urunıd,Adminıd")] TblMudur tblMudur)
        {
            if (ModelState.IsValid)
            {
                string wwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(tblMudur.imageFile.FileName);
                string extention = Path.GetExtension(tblMudur.imageFile.FileName);
                tblMudur.imageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extention;
                string path = Path.Combine(wwRootPath + "/image/Mudur/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await tblMudur.imageFile.CopyToAsync(fileStream);
                }
                

                _context.Add(tblMudur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblMudur);
        }

        // GET: TblMudurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMudur = await _context.TblMudurs.FindAsync(id);
            if (tblMudur == null)
            {
                return NotFound();
            }
            return View(tblMudur);
        }

        // POST: TblMudurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Müdürıd,imageName,Ad,Soyad,Tc,Adress,Tel,Email,MüdürMaaş,Urunıd,Adminıd")] TblMudur tblMudur)
        {
            if (id != tblMudur.Müdürıd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblMudur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblMudurExists(tblMudur.Müdürıd))
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
            return View(tblMudur);
        }

        // GET: TblMudurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMudur = await _context.TblMudurs
                .FirstOrDefaultAsync(m => m.Müdürıd == id);
            if (tblMudur == null)
            {
                return NotFound();
            }

            return View(tblMudur);
        }

        // POST: TblMudurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblMudur = await _context.TblMudurs.FindAsync(id);
            _context.TblMudurs.Remove(tblMudur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblMudurExists(int id)
        {
            return _context.TblMudurs.Any(e => e.Müdürıd == id);
        }
    }
}

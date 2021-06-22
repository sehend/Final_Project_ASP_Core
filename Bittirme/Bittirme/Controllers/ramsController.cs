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
    public class ramsController : Controller
    {
        private readonly E_TicaretContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ramsController(E_TicaretContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: rams
        public async Task<IActionResult> Index()
        {
            return View(await _context.ram.ToListAsync());
        }

        // GET: rams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ram = await _context.ram
                .FirstOrDefaultAsync(m => m.ramıd == id);
            if (ram == null)
            {
                return NotFound();
            }

            return View(ram);
        }

        // GET: rams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: rams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ramıd,imageFile,Aciklama,Fiyat")] ram ram)
        {
            if (ModelState.IsValid)
            {
                string wwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(ram.imageFile.FileName);
                string extention = Path.GetExtension(ram.imageFile.FileName);
                ram.imageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extention;
                string path = Path.Combine(wwRootPath + "/image/Ram/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await ram.imageFile.CopyToAsync(fileStream);
                }



                _context.Add(ram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ram);
        }

        // GET: rams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ram = await _context.ram.FindAsync(id);
            if (ram == null)
            {
                return NotFound();
            }
            return View(ram);
        }

        // POST: rams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ramıd,imageName,Aciklama,Fiyat")] ram ram)
        {
            if (id != ram.ramıd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ramExists(ram.ramıd))
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
            return View(ram);
        }

        // GET: rams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ram = await _context.ram
                .FirstOrDefaultAsync(m => m.ramıd == id);
            if (ram == null)
            {
                return NotFound();
            }

            return View(ram);
        }

        // POST: rams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ram = await _context.ram.FindAsync(id);
            _context.ram.Remove(ram);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ramExists(int id)
        {
            return _context.ram.Any(e => e.ramıd == id);
        }
    }
}

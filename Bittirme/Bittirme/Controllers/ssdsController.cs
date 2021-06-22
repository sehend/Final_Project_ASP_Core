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
    public class ssdsController : Controller
    {
        private readonly E_TicaretContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ssdsController(E_TicaretContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: ssds
        public async Task<IActionResult> Index()
        {
            return View(await _context.ssd.ToListAsync());
        }

        // GET: ssds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ssd = await _context.ssd
                .FirstOrDefaultAsync(m => m.ssdıd == id);
            if (ssd == null)
            {
                return NotFound();
            }

            return View(ssd);
        }

        // GET: ssds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ssds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ssdıd,imageFile,Aciklama,Fiyat")] ssd ssd)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    string wwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(ssd.imageFile.FileName);
                    string extention = Path.GetExtension(ssd.imageFile.FileName);
                    ssd.imageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extention;
                    string path = Path.Combine(wwRootPath + "/image/ssd/", fileName);

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await ssd.imageFile.CopyToAsync(fileStream);
                    }
                    _context.Add(ssd);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(ssd);
        }

        // GET: ssds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ssd = await _context.ssd.FindAsync(id);
            if (ssd == null)
            {
                return NotFound();
            }
            return View(ssd);
        }

        // POST: ssds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ssdıd,imageName,Aciklama,Fiyat")] ssd ssd)
        {
            if (id != ssd.ssdıd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ssd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ssdExists(ssd.ssdıd))
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
            return View(ssd);
        }

        // GET: ssds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ssd = await _context.ssd
                .FirstOrDefaultAsync(m => m.ssdıd == id);
            if (ssd == null)
            {
                return NotFound();
            }

            return View(ssd);
        }

        // POST: ssds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ssd = await _context.ssd.FindAsync(id);
            _context.ssd.Remove(ssd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ssdExists(int id)
        {
            return _context.ssd.Any(e => e.ssdıd == id);
        }
    }
}

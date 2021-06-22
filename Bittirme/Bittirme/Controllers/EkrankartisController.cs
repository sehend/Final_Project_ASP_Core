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
    public class EkrankartisController : Controller
    {
        private readonly E_TicaretContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public EkrankartisController(E_TicaretContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Ekrankartis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ekrankarti.ToListAsync());
        }

        // GET: Ekrankartis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ekrankarti = await _context.Ekrankarti
                .FirstOrDefaultAsync(m => m.ekrankartıd == id);
            if (ekrankarti == null)
            {
                return NotFound();
            }

            return View(ekrankarti);
        }

        // GET: Ekrankartis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ekrankartis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ekrankartıd,imageFile,Aciklama,Fiyat")] Ekrankarti ekrankarti)
        {
            if (ModelState.IsValid)
            {


                string wwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(ekrankarti.imageFile.FileName);
                string extention = Path.GetExtension(ekrankarti.imageFile.FileName);
                ekrankarti.imageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extention;
                string path = Path.Combine(wwRootPath + "/image/EkranKartı/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await ekrankarti.imageFile.CopyToAsync(fileStream);
                }









                _context.Add(ekrankarti);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ekrankarti);
        }

        // GET: Ekrankartis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ekrankarti = await _context.Ekrankarti.FindAsync(id);
            if (ekrankarti == null)
            {
                return NotFound();
            }
            return View(ekrankarti);
        }

        // POST: Ekrankartis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ekrankartıd,imageName,Aciklama,Fiyat")] Ekrankarti ekrankarti)
        {
            if (id != ekrankarti.ekrankartıd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ekrankarti);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EkrankartiExists(ekrankarti.ekrankartıd))
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
            return View(ekrankarti);
        }

        // GET: Ekrankartis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ekrankarti = await _context.Ekrankarti
                .FirstOrDefaultAsync(m => m.ekrankartıd == id);
            if (ekrankarti == null)
            {
                return NotFound();
            }

            return View(ekrankarti);
        }

        // POST: Ekrankartis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ekrankarti = await _context.Ekrankarti.FindAsync(id);
            _context.Ekrankarti.Remove(ekrankarti);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EkrankartiExists(int id)
        {
            return _context.Ekrankarti.Any(e => e.ekrankartıd == id);
        }
    }
}

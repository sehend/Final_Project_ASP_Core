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
    public class miceController : Controller
    {
        private readonly E_TicaretContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public miceController(E_TicaretContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: mice
        public async Task<IActionResult> Index()
        {
            return View(await _context.mouse.ToListAsync());
        }

        // GET: mice/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mouse = await _context.mouse
                .FirstOrDefaultAsync(m => m.mouseId == id);
            if (mouse == null)
            {
                return NotFound();
            }

            return View(mouse);
        }

        // GET: mice/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: mice/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mouseId,imageFile,Aciklama,Fiyat")] mouse mouse)
        {
            if (ModelState.IsValid)
            {
                string wwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(mouse.imageFile.FileName);
                string extention = Path.GetExtension(mouse.imageFile.FileName);
                mouse.imageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extention;
                string path = Path.Combine(wwRootPath + "/image/mouse/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await mouse.imageFile.CopyToAsync(fileStream);
                }






                _context.Add(mouse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mouse);
        }

        // GET: mice/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mouse = await _context.mouse.FindAsync(id);
            if (mouse == null)
            {
                return NotFound();
            }
            return View(mouse);
        }

        // POST: mice/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mouseId,imageName,Aciklama,Fiyat")] mouse mouse)
        {
            if (id != mouse.mouseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mouse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!mouseExists(mouse.mouseId))
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
            return View(mouse);
        }

        // GET: mice/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mouse = await _context.mouse
                .FirstOrDefaultAsync(m => m.mouseId == id);
            if (mouse == null)
            {
                return NotFound();
            }

            return View(mouse);
        }

        // POST: mice/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mouse = await _context.mouse.FindAsync(id);
            _context.mouse.Remove(mouse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool mouseExists(int id)
        {
            return _context.mouse.Any(e => e.mouseId == id);
        }
    }
}

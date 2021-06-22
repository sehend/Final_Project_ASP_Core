using Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bittirme.Controllers
{
    public class Excel : Controller
    {
        private readonly E_TicaretContext _context;

        public Excel(E_TicaretContext context)
        {
            _context = context;
        }
        

        public IActionResult SatısExcel(string p)
        {
            var degerler = from d in _context.TblSatis select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Ad.Contains(p));
            }


            return View(degerler.ToList());
        }

        public IActionResult MusterisExcel(string p)
        {
            var degerler = from d in _context.TblMusteris select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Ad.Contains(p));
            }


            return View(degerler.ToList());
        }

        public IActionResult PersonelExcel(string p)
        {
            var degerler = from d in _context.TblPersonels select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Ad.Contains(p));
            }


            return View(degerler.ToList());
        }
        public IActionResult MudurExcel(string p)
        {
            var degerler = from d in _context.TblMudurs select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Ad.Contains(p));
            }


            return View(degerler.ToList());
        }
        public IActionResult RamExcel(string p)
        {
            var degerler = from d in _context.ram select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Aciklama.Contains(p));
            }


            return View(degerler.ToList());

        }
        public IActionResult EkranKartıExcel(string p)
        {
            var degerler = from d in _context.Ekrankarti select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Aciklama.Contains(p));
            }


            return View(degerler.ToList());

        }
        public IActionResult mouseExcel(string p)
        {
            var degerler = from d in _context.mouse select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Aciklama.Contains(p));
            }


            return View(degerler.ToList());

        }
        public IActionResult ssdExcel(string p)
        {
            var degerler = from d in _context.ssd select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Aciklama.Contains(p));
            }


            return View(degerler.ToList());

        }
    }
}

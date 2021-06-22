using Bittirme.Models;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bittirme.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly E_TicaretContext _context;

        public HomeController(ILogger<HomeController> logger, E_TicaretContext context)
        {

            _logger = logger;
            _context = context;

        }
        public IActionResult GirisYap(string a, int b)
        {

      
                var deger1 = _context.TblPersonels.FirstOrDefault(x => x.Ad == a && x.Tc == b);

            if (deger1 != null)
            {


                return RedirectToAction("Index", "TblPersonels");



            }


            var deger2 = _context.TblMudurs.FirstOrDefault(x => x.Ad == a && x.Tc == b);

            if (deger2 != null)
            {


                return RedirectToAction("Index", "TblMudurs");



            }

            var deger3 = _context.TblMusteris.FirstOrDefault(x => x.Ad == a && x.Tc == b);

            if (deger3 != null)
            {


                return RedirectToAction("Index", "HomeSatıs");



            }


            return View();
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ekrankarti.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

  
        public async Task<IActionResult> EkranKartı()
        {
            return View(await _context.Ekrankarti.ToListAsync());
        }

        public async Task<IActionResult> Ram()
        {
            return View(await _context.ram.ToListAsync());
        }


        public async Task<IActionResult> Mouse()
        {
            return View(await _context.mouse.ToListAsync());
        }




        public async Task<IActionResult> SSD()
        {
            return View(await _context.ssd.ToListAsync());
        }













    }
}

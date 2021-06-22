using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bittirme.Controllers
{
    public class HomeSatısController : Controller
    {
        private readonly ILogger<HomeSatısController> _logger;
        private readonly E_TicaretContext _context;

        public HomeSatısController(ILogger<HomeSatısController> logger, E_TicaretContext context)
        {

            _logger = logger;
            _context = context;

        }
     
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ekrankarti.ToListAsync());
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

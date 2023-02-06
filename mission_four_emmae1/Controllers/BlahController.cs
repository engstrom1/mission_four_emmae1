using Microsoft.AspNetCore.Mvc;
using mission_four_emmae1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission_four_emmae1.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult gradeCalc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult gradeCalc(gradeCalcModel model)
        {
            return View();
        }
    }
}

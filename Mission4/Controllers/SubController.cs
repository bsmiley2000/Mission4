using Microsoft.AspNetCore.Mvc;
using Mission4ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class SubController : Controller
    {
        
        public IActionResult Index ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult GradeCalculator(GradeModel cls)
        {
/*            if (ModelState.IsValid)
            {
               
            }*/
            return View();
        }
    }
}

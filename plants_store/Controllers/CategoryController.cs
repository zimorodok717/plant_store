using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace online_pharmacy.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Bads()
        {
            return View();
        }
        public IActionResult Medicines()
        {
            return View();
        }
        public IActionResult Electronics()
        {
            return View();
        }
        public IActionResult Cosmetics()
        {
            return View();
        }
    }
}

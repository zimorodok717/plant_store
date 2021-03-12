using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace online_pharmacy.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Search1()
        {
            return View();
        }

        public IActionResult Search2()
        {
            return View();
        }

        public IActionResult Search4()
        {
            return View();
        }

        public IActionResult Search3()
        {
            return View();
        }

        public IActionResult Search5()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(IFormCollection collection)
        {
            string z, p, h;
            bool zc = false, pc = false, hc = false;
            if (!string.IsNullOrEmpty(collection["poch"]))
            {
                p = collection["poch"];
                pc = Convert.ToBoolean(p);
            }

            if (!string.IsNullOrEmpty(collection["zkt"]))
            {
                z = collection["zkt"];
                zc = Convert.ToBoolean(z);
            }

            if (!string.IsNullOrEmpty(collection["hip"]))
            {
                h = collection["hip"];
                hc = Convert.ToBoolean(h);
            }

            if (hc == false && zc==false && pc== true)
            {
                return View("Search3");
            }
            else if (zc == false && pc == true)
            {
                return View("Search2");
            }
            else if (zc == true && pc == true)
            {
                return View("Nothing");
            }
            else return View("Nothing");


        }
    }
}

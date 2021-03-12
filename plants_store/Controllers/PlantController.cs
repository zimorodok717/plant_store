using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace plant_store.Controllers
{
    public class PlantController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Enter()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Client(string name, string pass)
        {
            if (name.Equals("admin") & pass.Equals("admin"))
            {
                return View("AdminStart");
            }
            if (name.Equals("user") & pass.Equals("user"))
            {
                return View();
            }
            else{ return View("Mistaken"); }
            
        }
        public class PlantController : Controller
{
    IRepository<Plant> db;
 
    public PlantController()
    {
        db = new ШPlantRepository();
    }
 [HttpGet]
    public ActionResult Index()
    {
        return View(db. GetPlants ());
    }
 public IActionResult GetPlant(int? id)
        {
            if (!id.HasValue)
                return BadRequest();
            Plant plant = repo.Get(id.Value);
            if (plant == null)
                return NotFound();
            return View(plant);
        }
 
        public IActionResult AddPlant() => View();

    [HttpPost]
    public ActionResult Add(Plant plant)
    {
        if(ModelState.IsValid)
        {
            db.Create(plant);
            db.Save();
            return RedirectToAction("Index");
        }
        return View(plant);
    }

        public IActionResult Del()
        {
            return View("Up1");
        }
        public IActionResult Ll()
        {
            return View("Up");
        }
        public IActionResult Rou()
        {
            return View("Route");
        }
    }
}

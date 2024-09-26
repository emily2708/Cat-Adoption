using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cat_Adoption.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cat_Adoption.Controllers
{
    public class CatController : Controller
    {

        public readonly ApplicationDbContext db;

        public CatController(ApplicationDbContext _db){
            db = _db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.CatsForAdoption.ToList());
        }

        public IActionResult SingleCat(int id)
        {
            var cat = db.CatsForAdoption.FirstOrDefault(c => c.id == id);
            return View(cat);
        }
    }
}


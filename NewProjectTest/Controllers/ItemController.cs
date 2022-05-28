using NewProjectTest.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewProjectTest.Models;

namespace NewProjectTest.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ItemController(ApplicationDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.CoConversion;
            return View(objList);

        }
        //Get Create
        public IActionResult Create()
        {
                       return View();
                }
        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.CoConversion.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
      

        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.CoConversion.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.CoConversion.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET-Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.CoConversion.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        // GET-Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.CoConversion.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Item obj)
        {
            if (ModelState.IsValid)
            {
                _db.CoConversion.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}


        
    


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Restaurant.Data;
using Restaurant.Migrations;
using Restaurant.Models;
using Restaurant.Repository;
using System.ComponentModel;

namespace Restaurant.Controllers
{
    public class RestaurantMenuController : Controller
    {
        private IRestaurantMenuRepo _restRepo;
        public RestaurantMenuController(IRestaurantMenuRepo restRepo)
        {
                _restRepo = restRepo;
        }

        public IActionResult Index()
        {
            var result = _restRepo.GetAll();
            return View(result);    
        }

        public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Create(RestaurantMenus obj)
        {
            if (ModelState.IsValid)
            {
                _restRepo.Create(obj);
                _restRepo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Update(int id)
        {
            if(id == 0)
            {
                return NotFound(id);
            }
            var findId = _restRepo.GetById(id);
            return View(findId);
        }

        [HttpPost]
        public IActionResult Update(RestaurantMenus obj)
        {
            if (ModelState.IsValid)
            {
                _restRepo.Update(obj);
                _restRepo.Save();
                return RedirectToAction("Index");   
            }
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            var findId = _restRepo.GetById(id);
            return View(findId);
        }

        [HttpPost]
        public IActionResult Delete(RestaurantMenus obj)
        {
            if (obj != null)
            {
               _restRepo.Delete(obj);
                _restRepo.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
  
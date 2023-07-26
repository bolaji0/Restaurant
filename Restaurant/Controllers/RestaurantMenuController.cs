using Microsoft.AspNetCore.Mvc;
using Restaurant.Data;
using Restaurant.Migrations;
using Restaurant.Models;
using System.ComponentModel;

namespace Restaurant.Controllers
{
    public class RestaurantMenuController : Controller
    {
        private readonly AppDbContext _db;
        public RestaurantMenuController(AppDbContext db)
        {
            _db = db;
        }   

        //[HttpGet] Read
        //[HttpPost] Create
        //[HttpPut] Update
        //[HttpDelete] Delete


        public IActionResult Index()
        {
            IEnumerable<RestaurantMenus> objCategoryList = _db.menu;
            return View (objCategoryList);
        }

        public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Create(RestaurantMenus obj)
        {
            //ModelState
            _db.menu.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");  
        }

    }
}
  
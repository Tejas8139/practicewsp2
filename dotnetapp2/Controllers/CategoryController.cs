using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetapp2.Models;


namespace dotnetapp2.Controllers
{
 
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db =db;
        }
        public IActionResult Index()
        {
            //var objCategoryList =_db.Categories.ToList();
            List<Category1>objCategoryList = _db.Categories2.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category1 obj)
        {
            _db.Categories2.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index","Category");
        }

    }
}
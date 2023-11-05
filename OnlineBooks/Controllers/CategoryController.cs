using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BooksOnline.Controllers;
using BooksOnline.Models;
namespace BooksOnline.Controllers
{
  
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
       
       public CategoryController(ApplicationDbContext db)
       {
            _db = db;
       }
        public IActionResult Show()
        {
            var objCategoryList = _db.category1.ToList();
            //or
            // List<Category>objCategoryList = _db.category1.ToList();
            // return View();
        }

    
    }
}
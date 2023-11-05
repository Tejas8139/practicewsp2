using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetapp1.Models;

namespace dotnetapp1.Controllers
{
 
    public class CategoryController : Controller
    {

        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db =db;
        }
        public IActionResult Index()
        {
            var objCategoryList =_db.Categoriess.ToList();
            return View();
        }

    }
}
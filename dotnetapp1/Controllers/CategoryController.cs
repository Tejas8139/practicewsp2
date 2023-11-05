using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetapp1.Controllers
{
 
    public class CategoryController : Controller
    {

        private readonly AppContext _db;

        public CategoryController(AppDbContext db)
        {
            _db =db;
        }
        public IActionResult Index()
        {
            var objCategoryList =_db
            return View();
        }

    }
}
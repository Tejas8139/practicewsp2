using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BooksOnline.Controllers;
namespace BooksOnline.Controllers
{
  
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
       
       public CategoryController(ApplicationDbContext db)
       {
        
       }
        public IActionResult Index()
        {
            return View();
        }

    
    }
}
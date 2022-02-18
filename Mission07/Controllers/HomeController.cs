using Microsoft.AspNetCore.Mvc;
using Mission07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission07.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }
        
        /*public IActionResult Index() => View();*/
        public IActionResult Index()
        {
            var variable1 = repo.Books.ToList();
            
            return View(variable1);
        }

        
    }
}

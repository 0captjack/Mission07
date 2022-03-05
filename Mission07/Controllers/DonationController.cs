using Microsoft.AspNetCore.Mvc;
using Mission07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission07.Controllers
{
    public class DonationController : Controller
    {
        public IActionResult Checkout()
        {
            return View(new Donation());
        }
    }
}

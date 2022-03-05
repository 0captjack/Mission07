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
        private IDonationRepository repo { get; set; }
        private Cart cart { get; set; }
        public DonationController (IDonationRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }
        
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Donation());
        }

        [HttpPost]
        public IActionResult Checkout(Donation donation)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Your Cart is empty");
            }
            
            if (ModelState.IsValid)
            {
                donation.Lines = cart.Items.ToArray();
                repo.SaveDonation(donation);
                cart.ClearCart();

                return RedirectToPage("/PurchaseComplete");
            }
            else
            {
                return View();
            }
        }
    }
}

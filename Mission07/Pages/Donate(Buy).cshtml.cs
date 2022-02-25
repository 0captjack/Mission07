using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission07.Infrastructure;
using Mission07.Models;

namespace Mission07.Pages
{
    public class Donate_Buy_Model : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public Donate_Buy_Model (IBookstoreRepository temp)
        {
            repo = temp;
        }
        //This is the controller for the Shopping Cart ??
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            cart.AddItem(b, 1);
            //the power of a session & cached data
            HttpContext.Session.SetJson("cart", cart);
            //returnURL wizardry
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
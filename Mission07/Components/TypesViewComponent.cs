using Microsoft.AspNetCore.Mvc;
using Mission07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission07.Components
{
    public class TypesViewComponent : ViewComponent
    {

        private IBookstoreRepository repo { get; set; }
        public TypesViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookType"];
            
            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }
    }
}

//public class BasketSummaryViewComponent : ViewComponent
//{
//    private Cart cart;

//    public BasketSummaryViewComponent(Cart cartService)
//    {
//        cart = cartService;
//    }
//    public IViewComponentResult Invoke()
//    {
//        return View(cart);
//    }
//}
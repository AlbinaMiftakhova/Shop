using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        ShopEntities storeDB = new ShopEntities();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            var clothes = GetTopSellingClothes(5);
            return View(clothes);
        }

        private List<Clothing> GetTopSellingClothes(int count)
        {
            return storeDB.Clothes.OrderByDescending(a => a.OrderDetails.Count()).Take(count).ToList();
        }
    }
}
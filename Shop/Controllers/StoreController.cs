﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class StoreController : Controller
    {
        ShopEntities storeDB = new ShopEntities();
        public ActionResult Index()
        {
            var categories = storeDB.Categories.ToList();
            return View(categories);
        }

        public ActionResult Browse(string category)
        {
            var categoryModel = storeDB.Categories.Include("Clothes")
                .Single(g => g.Name == category);

            return View(categoryModel);
        }
        public ActionResult Details(int id)
        {
            var clothing = storeDB.Clothes.Find(id);
            return View(clothing);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();
            return PartialView(categories);
        }
    }
}
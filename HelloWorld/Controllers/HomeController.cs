﻿using HelloWorld.Models;// call on it
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            int x = 1;  // add me
            x = x / (x - 1); // add me
            return View();
        }

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    base.OnException(filterContext);
        //}
        public ActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(Models.GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        private Product myProduct = new Product
        {
            ProductId = 1,
            Name = "Kayak",
            Description = "A boat for one person",
            Category = "water-sports",
            Price = 200m,
        };

        public ActionResult Product()
        {
            return View(myProduct);
        }

        public ActionResult Products()
        {

            var products = new Product[]
                {
                    new Product{ ProductId = 1, Name = "First One", Price = 1.11m, ProductCount=0},
                    new Product{ ProductId = 2, Name="Second One", Price = 2.22m, ProductCount=1},
                    new Product{ ProductId = 3, Name="Third One", Price = 3.33m, ProductCount=2},
                    new Product{ ProductId = 4, Name="Fourth One", Price = 4.44m, ProductCount=10},
                };

            return View(products);
        }
    }
}
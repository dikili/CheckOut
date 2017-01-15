using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DrinksInventory.Data;
using DrinksInventory.Data.Interfaces;
using DrinksInventory.Data.Repositories;

namespace DrinksInventory.API.Controllers
{
    

    public class HomeController : Controller
    {
        private IDrinkRepository _drinkRepo;

        public HomeController()
        {
        
        }
       
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }


    }
}

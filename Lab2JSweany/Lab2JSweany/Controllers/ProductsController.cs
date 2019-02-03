using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2JSweany.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            ViewBag.Message = "Products/Index is displayed";
            return View();
        }

        // Older code for GET: Products
        //public string Index()
        //{
        //    return "Products/Index is displayed";
        //}

        // GET: Products/Browse
        public ActionResult Browse()
        {
            ViewBag.Message = "Browse displayed";
            return View();
        }

        /* Older code for GET: Products/Browse
        public string Browse()
        {
            return "Browse displayed";
        }
       */

        // GET: Products/Details/105
        public ActionResult Details(int id)
        {
            ViewBag.Message = "Details displayed for Id=" + id;
            return View();
        }
        
        // GET: Products/Location?zip=44124
        public ActionResult Location(string zip)
        {
            ViewBag.Message = "Location displayed for zip=" + zip;
            return View();
        }

     
    }
}
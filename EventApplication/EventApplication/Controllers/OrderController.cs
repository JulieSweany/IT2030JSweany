﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;

namespace EventApplication.Controllers
{
    public class OrderController : Controller
    {
        EventApplicationDB db = new EventApplicationDB();

        // GET: OrderSummaryCart
        public ActionResult Index()
        {
            OrderSummary thesummary = new OrderSummary();
            thesummary = OrderSummary.GetOrder(this.HttpContext);

            OrderSummaryViewModel vm = new OrderSummaryViewModel()
            {
                OrderItems = thesummary.GetOrderItems()
            };

            return View(vm);
        }


        // GET: Order/AddOrder ---ORIGINAL--Will need one that take in int for Count, too
        public ActionResult AddOrder(int id)
        {
            OrderSummary order = OrderSummary.GetOrder(this.HttpContext);
            order.AddOrder(id);
            //return RedirectToAction("OrderSummary");
            return RedirectToAction("Index");
        }
    }    
}
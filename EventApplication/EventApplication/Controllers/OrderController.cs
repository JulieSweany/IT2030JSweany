using System;
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

        // GET: OrderCart
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

        
        //Register for event in controller
        // GET: Order/AddOrder
        public ActionResult AddOrder(int id)
        {
            OrderSummary order = OrderSummary.GetOrder(this.HttpContext);
            order.AddOrder(id);
            //return RedirectToAction("OrderSummary");    --- will need this after authentication implemented
            return RedirectToAction("Index");
        }


        // POST: OrderCart/RemoveOrder
        [HttpPost]
        public ActionResult RemoveOrder()
        {
            throw new NotImplementedException();
        }
    }
}
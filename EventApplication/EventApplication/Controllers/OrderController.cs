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

        
        // GET: Order/AddOrder
        public ActionResult AddOrder(int id)
        {
            OrderSummary order = OrderSummary.GetOrder(this.HttpContext);
            order.AddOrder(id);
            //return RedirectToAction("OrderSummary");
            return RedirectToAction("Index");
        }

        //GET Register
        //need to get count
        public ActionResult Register(int id)
        {
            OrderSummary order = OrderSummary.GetOrder(this.HttpContext);
            order.AddOrder(id);

           //OrderSummary thesummary = new OrderSummary();
           //thesummary = OrderSummary.GetOrder(this.HttpContext);

            /*
             * OrderSummaryViewModel vm = new OrderSummaryViewModel()
            {
                OrderItems = order.GetOrderItems()
            };
            */
            //just added "SingleOrderViewModel.cs" still needs info in that class, too
            return View();
        }
        // POST: OrderCart/RemoveOrder
        [HttpPost]
        public ActionResult RemoveOrder()
        {
            throw new NotImplementedException();
        }
    }
}
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
        public ActionResult GoToMyTickets()
        {
            //OrderSummary thesummary = new OrderSummary();
            //thesummary = OrderSummary.GetOrder(this.HttpContext);

            OrderSummary ordersOfUser = OrderSummary.GetOrder(this.HttpContext);


            OrderSummaryViewModel vm = new OrderSummaryViewModel()
            {
                OrderItems = ordersOfUser.GetOrderItems()
            };

            return View(vm);
        }
        //GET Checkout
        //receives int id only at this point
        
        public ActionResult Checkout(int id)
        {
            
            OrderSummary order = OrderSummary.GetOrder(this.HttpContext);
            order.AddOrder(id);

            /*
            SingleOrderViewModel vm = new SingleOrderViewModel()
            {
                SingleOrder = order.GetSingleOrder()
            };
            */
            OrderSummaryViewModel vm = new OrderSummaryViewModel()
            {
                OrderItems = order.GetOrderItems()
            };

            return View(vm);
        }

        //public ActionResult BackToBrowse()
        //{
        //    return RedirectToAction("Events/Index");
        //}
    
        /*
        public ActionResult OrderReview()
        {
            OrderSummary thesummary = new OrderSummary();
            thesummary = OrderSummary.GetOrder(this.HttpContext);

            OrderSummaryViewModel vm = new OrderSummaryViewModel()
            {
                OrderItems = singleOrder.GetSingleOrder()
            };

            return View(vm);
        }
        */



        //Register was moved back to home again
        /*
        public ActionResult Register (int id)
        {
            OrderSummary order = OrderSummary.GetOrder(this.HttpContext);
            order.AddOrder(id);

            
            OrderSummary thesummary = new OrderSummary();
            thesummary = OrderSummary.GetOrder(this.HttpContext);
            OrderSummaryViewModel vm = new OrderSummaryViewModel()
            {
                OrderItems = thesummary.GetOrderItems()
            };
           
            return View();
        }
     */


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
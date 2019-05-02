using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;

namespace EventApplication.Controllers
{
    public class OrderCartController : Controller
    {
        // GET: OrderCart
        public ActionResult Index()
        {
            OrderCart cart = OrderCart.GetCart(this.HttpContext);

            OrderCartViewModel vm = new OrderCartViewModel()
            {
                CartItems = cart.GetCartItems()
            };

            return View(vm);
        }

        // GET: OrderCart/AddToCart
        public ActionResult AddToCart(int id)
        {
            OrderCart cart = OrderCart.GetCart(this.HttpContext);
            cart.AddToCart(id);
            return RedirectToAction("Index");
        }

        /*Start over with Register in OrderCart.cs based on AddToCart in OrderCart.cs?
        public ActionResult Register(int id)
        {
            OrderCart cart = OrderCart.GetCart(this.HttpContext);
            OrderSummaryViewModel vm = new OrderSummaryViewModel()
            {
                CartItems = cart.GetCartItems()
            };

            //int id is value for EventId-- need to assign it here?
            return Register(vm);
        }
        */

        // POST: OrderCart/RemoveOrder
        [HttpPost]
        public ActionResult RemoveOrder()
        {
            throw new NotImplementedException();
        }
    }
}
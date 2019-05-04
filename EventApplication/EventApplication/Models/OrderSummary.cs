using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventApplication.Models;
using System.Security.Principal;
using Microsoft.AspNet.Identity;

namespace EventApplication.Models
{
    public class OrderSummary
    {
        private EventApplicationDB db = new EventApplicationDB();
        
        public string UserId;

        //I don't think this will work now that there is a user id; changing below
        /*
         * public static OrderSummary GetOrder(HttpContextBase context)
        {
            OrderSummary order = new OrderSummary();
            order.UserId = order.GetOrderId(context);
            return order;
        }
        */

        public static OrderSummary GetOrder(HttpContextBase context)
        {
            OrderSummary order = new OrderSummary();

            string userId;
            userId = context.User.Identity.Name;
            order.UserId = userId;
            
            //order.UserId = order.GetOrderId(context); --I don't think this worked
            return order;
        }
       
      

        public List<Order> GetOrderItems()
        {
            return db.Orders.Where(o => o.UserId == this.UserId).ToList();
        }

        
        
        public void AddOrder(int eventId)
        {

        Order orderItem = db.Orders.SingleOrDefault(o => o.UserId == this.UserId && o.EventId == eventId);

            if (orderItem == null)
            {
                orderItem = new Order()
                {
                    UserId = this.UserId,
                    OrderId = this.UserId,
                    OrderNumber = Guid.NewGuid().ToString(),
                    EventId = eventId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                db.Orders.Add(orderItem);
            }
            else
            {
                orderItem.Count++;
            }
            db.SaveChanges();
        }

        
        
    }

}
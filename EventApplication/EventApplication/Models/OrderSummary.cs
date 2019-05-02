using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventApplication.Models;

namespace EventApplication.Models
{
    public class OrderSummary
    {
        public string OrderSummaryId;

        private EventApplicationDB db = new EventApplicationDB();

        public static OrderSummary GetOrder(HttpContextBase context)
        {
            OrderSummary order = new OrderSummary();
            order.OrderSummaryId = order.GetOrderId(context);
            return order;
        }

        private string GetOrderId(HttpContextBase context)
        {
            const string OrderSessionId = "OrderId";

            string orderId;

            if (context.Session[OrderSessionId] == null)
            {
                orderId = Guid.NewGuid().ToString();
                context.Session[OrderSessionId] = orderId;
            }

            else
            {
                orderId = context.Session[OrderSessionId].ToString();
            }

            return orderId;
        }

        public List<Order> GetOrderItems()
        {
            return db.Orders.Where(o => o.OrderId == this.OrderSummaryId).ToList();
        }

        //Register for event (in model)
        public void AddOrder(int eventId)
        {
            Order orderItem = db.Orders.SingleOrDefault(o => o.OrderId == this.OrderSummaryId && o.EventId == eventId);

            if (orderItem == null)
            {
                orderItem = new Order()
                {
                    OrderId = OrderSummaryId,
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
﻿using System;
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

        public static OrderSummary GetOrder(HttpContextBase context)
        {
            OrderSummary order = new OrderSummary();
            order.UserId = order.GetOrderId(context);
            return order;
        }

        private string GetOrderId(HttpContextBase context)
        {
            //const string CartSessionKey = "UserId";

            string userId;
            userId = context.User.Identity.Name;

            return userId;
            /*
            if (context.Session[CartSessionKey] == null)
                { 
                    if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                    {
                        context.Session[CartSessionKey] = context.User.Identity.Name;

                    userId = context.Session[CartSessionKey].ToString();

                }
            }
             if (context.Session[OrderSessionId] == null)
             {
                 orderId = Guid.NewGuid().ToString();
                 context.Session[OrderSessionId] = orderId;
             }
             
            else
            {
                userId = context.Session[CartSessionKey].ToString();
            }

            return userId;
            */
        }
        
        

        public List<Order> GetOrderItems()
        {
            return db.Orders.Where(o => o.UserId == this.OrderSummaryId).ToList();
        }


        //Checkout and go to Order Summary
        public string OrderSummaryId;

        
        public void AddOrder(int eventId)
        {

        Order orderItem = db.Orders.SingleOrDefault(o => o.UserId == this.OrderSummaryId && o.EventId == eventId);

            if (orderItem == null)
            {
                orderItem = new Order()
                {
                    UserId = OrderSummaryId,
                    EventId = eventId,
                    Count = 1,
                    OrderNumber = Guid.NewGuid().ToString(),
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



        //AddOrder that worked before adding registration
        /*
        public void AddOrder(int eventId)
        {
            Order orderItem = db.Orders.SingleOrDefault(o => o.OrderId == this.OrderSummaryId && o.EventId == eventId);

            if (orderItem == null)
            {
                orderItem = new Order()
                {
                    OrderId = UserId,
                    EventId = eventId,
                    Count = 1,
                    OrderNumber = Guid.NewGuid().ToString(),
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
        */
    }

}
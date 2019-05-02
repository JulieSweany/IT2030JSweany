using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class OrderCart
    {
        public string OrderCartId;

        private EventApplicationDB db = new EventApplicationDB();

        public static OrderCart GetCart(HttpContextBase context)
        {

            OrderCart cart = new OrderCart();
            cart.OrderCartId = cart.GetCartId(context);
            return cart;
        }

        private string GetCartId(HttpContextBase context)
        {
            const string CartSessionId = "CartId";

            string cartId;

            if(context.Session[CartSessionId] == null)
            {
                cartId = Guid.NewGuid().ToString();
                context.Session[CartSessionId] = cartId;
            }

            else
            {
                cartId = context.Session[CartSessionId].ToString();
            }

            return cartId;
        }



    /* not working--supposed to be GetCartId that uses registered user
        private string GetCartId(HttpContextBase context)
        {
            const string CartSessionKey = "CartId";

            string cartId;

            if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
            {
                context.Session[CartSessionKey] = context.User.Identity.Name;
                cartId = context.Session[CartSessionKey].ToString();
            }

            else
            {
                Guid tempCartId = Guid.NewGuid();
                context.Session[CartSessionKey] = tempCartId.ToString();
                cartId = tempCartId.ToString();
            }

            return cartId;
        }
        */
        
        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(c => c.CartId == this.OrderCartId).ToList();
        }

        public void AddToCart(int eventId)
        {
            //TODO: verify eventId exists in db

            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.OrderCartId && c.EventId == eventId);

            if (cartItem == null)
            { 
                //Item not in cart; add new item
                cartItem = new Cart()
                {
                    CartId = this.OrderCartId,
                    EventId = eventId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

            db.Carts.Add(cartItem);

            }

            else
            {
                //Item is in cart; increase item count
                cartItem.Count++;
            }

            db.SaveChanges();

        }

    }
        
}
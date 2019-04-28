using EventApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace EventApplication.Controllers
{
    public class EventSiteController : Controller
    {
        private EventApplicationDB db = new EventApplicationDB();

        public ActionResult LastMinuteDeals()
        {
            var dealEvents = GetDeals();
            return PartialView("_LastMinuteDeals", dealEvents);
        }

        private List<Event> GetDeals()
        {
            //this assigned correct value during debugging
            var dateCurrent = DateTime.Now.Date;

            //this assigned correct value during debugging
            var datePlusTwo = dateCurrent.AddDays(2);

            return db.Events.Where(a => a.StartDate <= datePlusTwo && a.StartDate >= dateCurrent).ToList();

            //this worked, but returned dates in the past, too
            //return db.Events.Where(a => (a.StartDate) <= datePlusOne).ToList();


      

        }

        // GET: EventSite
        public ActionResult Index()
        {
            var events = db.Events.Include(e => e.EventType);
            return View(db.Events.ToList());
        }
    }
}
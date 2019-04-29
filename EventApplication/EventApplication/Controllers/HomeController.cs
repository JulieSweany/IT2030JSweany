using EventApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace EventApplication.Controllers
{
    public class HomeController : Controller
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

        //(This worked as event and event type search (location search)
        public ActionResult EventSearch(string q)
        {
            var eventresults = GetByEvent(q);
            return PartialView("_EventSearchResultsHome", eventresults);
        }

        private List<Event> GetByEvent(string searchString)
        {
            var dateCurrent = DateTime.Now.Date;

            List<Event> matchingEvents = new List<Event>();
            List<Event> currentEvents = new List<Event>();

            matchingEvents = db.Events
                .Include(e => e.EventType)
                .Where(e => e.Title.Contains(searchString) || e.EventType.Name.Contains(searchString))
                .ToList();

            currentEvents = matchingEvents
                .Where(e => e.StartDate >= dateCurrent)
                .ToList();

            return currentEvents;
        }

       

        public ActionResult Index()
        {
            var events = db.Events.Include(e => e.EventType);
            return View(db.Events.ToList());
        }

        // GET: Events/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
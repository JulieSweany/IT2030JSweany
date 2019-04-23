using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EventApplication.Models
{
    public class SampleData : DropCreateDatabaseAlways<EventApplicationDBContext>
    {
        protected override void Seed(EventApplicationDBContext context)
        {
            var eventTypes = new List<EventType>
            {
                new EventType { Name = "Dance" },
                new EventType { Name = "Music" },
                new EventType { Name = "Outdoor Festivals" },
                new EventType { Name = "Film" },
                new EventType { Name = "Fundraisers" },
                new EventType { Name = "Marathons/Fun Runs" },
                new EventType { Name = "Poetry" },
                new EventType { Name = "Lecture" },
                new EventType { Name = "Workshops" },
                new EventType { Name = "Kids' Activities" },
                new EventType { Name = "Fitness and Health" },
                new EventType { Name = "Holiday" },
                new EventType { Name = "Gardening" },
                new EventType { Name = "Outdoor Recreation" },
                new EventType { Name = "Pets" },
                new EventType { Name = "Arts and Crafts" }
            };
            eventTypes.ForEach(a => context.EventTypes.Add(a));

            


        new List<Event>
            {
                new Event { EventTypeId = 1, Title = "Disco Inferno", Description = "Dance the night away to all your favorite disco hits", Organizer = "Disco Stu", ContactInfo = "216-555-1978", City = "Cleveland", State = "OH", StartDateTime = DateTime.Parse("06/12/19 19:00:00"), EndDateTime = DateTime.Parse("06/12/19 21:00:00"), MaxTickets = 100, TicketsAvailable = 100 },
                new Event { EventTypeId = 2, Title = "Lakewood Project July 4 Concert", Description = "Rock Orchestra plays classic hits at outdoor concert", Organizer = "Lakewood City Schools", ContactInfo = "OneLakewood.com", City = "Lakewood", State = "OH", StartDateTime = DateTime.Parse("07/04/19 17:00:00"), EndDateTime = DateTime.Parse("07/04/19 19:00:00"), MaxTickets = 3000, TicketsAvailable = 3000 },
                //new Event { EventTypeId = eventTypes.Single(e => e.Name == "Dance").EventTypeId, Title = "Disco Inferno", Description = "Dance the night away to all your favorite disco hits", Organizer = "Disco Stu", ContactInfo = "216-555-1978", City = "Cleveland", State = "OH", StartDateTime = DateTime.Parse("06/12/19 19:00:00"), EndDateTime = DateTime.Parse("06/12/19 21:00:00"), MaxTickets = 100, TicketsAvailable = 100 },
                //new Event { EventTypeId = eventTypes.Single(e => e.Name == "Music").EventTypeId, Title = "Lakewood Project July 4 Concert", Description = "Rock Orchestra plays classic hits at outdoor concert", Organizer = "Lakewood City Schools", ContactInfo = "OneLakewood.com", City = "Lakewood", State = "OH", StartDateTime = DateTime.Parse("07/04/19 17:00:00"), EndDateTime = DateTime.Parse("07/04/19 19:00:00"), MaxTickets = 3000, TicketsAvailable = 3000 },
            }.ForEach(a => context.Events.Add(a));
        }
    }
}


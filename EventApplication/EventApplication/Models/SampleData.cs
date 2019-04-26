using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EventApplication.Models
{
    public class SampleData : DropCreateDatabaseAlways<EventApplicationDB>
    {
        protected override void Seed(EventApplicationDB context)
        {
            var eventTypes = new List<EventType>
            {
                new EventType { Name = "Dance" },
                new EventType { Name = "Music" },
                new EventType { Name = "Outdoor Festivals" },
                new EventType { Name = "Fundraisers" },
                new EventType { Name = "Lectures" },
                new EventType { Name = "Workshops" },
                new EventType { Name = "Fitness and Health" },
                new EventType { Name = "Gardening" },
                new EventType { Name = "Outdoor Recreation" },
                new EventType { Name = "Pets" },
            };
            eventTypes.ForEach(a => context.EventTypes.Add(a));




            new List<Event>
            {
                new Event { EventType = eventTypes.Single(e => e.Name == "Dance"), Title = "Disco Inferno", Description = "Dance the night away to all your favorite disco hits", Organizer = "Disco Stu", ContactInfo = "216-555-1978", City = "Cleveland", State = "OH", StartDate = DateTime.Parse("06/12/19"), EndDate = DateTime.Parse("06/12/19"), StartTime = DateTime.Parse("19:00:00"), EndTime = DateTime.Parse("21:00:00"), MaxTickets = 100, TicketsAvailable = 100 },
                new Event { EventType = eventTypes.Single(e => e.Name == "Music"), Title = "Tuba Christmas 2019", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = DateTime.Parse("12/10/19"), EndDate = DateTime.Parse("12/10/19"), StartTime = DateTime.Parse("11:00:00"), EndTime = DateTime.Parse("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
               
                //new Event { EventTypeId = 1, Title = "Disco Inferno", Description = "Dance the night away to all your favorite disco hits", Organizer = "Disco Stu", ContactInfo = "216-555-1978", City = "Cleveland", State = "OH", StartDateTime = DateTime.Parse("06/12/19 19:00:00"), EndDateTime = DateTime.Parse("06/12/19 21:00:00"), MaxTickets = 100, TicketsAvailable = 100 },
                //new Event { EventTypeId = 2, Title = "Lakewood Project July 4 Concert", Description = "Rock Orchestra plays classic hits at outdoor concert", Organizer = "Lakewood City Schools", ContactInfo = "OneLakewood.com", City = "Lakewood", State = "OH", StartDateTime = DateTime.Parse("07/04/19 19:00:00"), EndDateTime = DateTime.Parse("07/04/19 19:00:00"), MaxTickets = 3000, TicketsAvailable = 3000 },
                //new Event { EventTypeId = 2, Title = "Tuba Christmas", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDateTime = DateTime.Parse("12/10/19 11:00:00"), EndDateTime = DateTime.Parse("12/10/19 13:30:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                //new Event { EventTypeId = 2, Title = "Mr. B Jazz Trio", Description = "Acclaimed jazz trio plays songs from latest release", Organizer = "Nighttown", ContactInfo = "someone@nighttown.com", City = "Cleveland", State = "OH", StartDateTime = DateTime.Parse("05/10/19 20:00:00"), EndDateTime = DateTime.Parse("05/10/19 23:30:00"), MaxTickets = 200, TicketsAvailable = 200 },
         
                //Genre = genres.Single(g => g.Name == "Classical")

                //new Event { EventTypeId = eventTypes.Single(e => e.Name == "Dance").EventTypeId, Title = "Disco Inferno", Description = "Dance the night away to all your favorite disco hits", Organizer = "Disco Stu", ContactInfo = "216-555-1978", City = "Cleveland", State = "OH", StartDateTime = DateTime.Parse("06/12/19 19:00:00"), EndDateTime = DateTime.Parse("06/12/19 21:00:00"), MaxTickets = 100, TicketsAvailable = 100 },
                //new Event { EventTypeId = eventTypes.Single(e => e.Name == "Music").EventTypeId, Title = "Lakewood Project July 4 Concert", Description = "Rock Orchestra plays classic hits at outdoor concert", Organizer = "Lakewood City Schools", ContactInfo = "OneLakewood.com", City = "Lakewood", State = "OH", StartDateTime = DateTime.Parse("07/04/19 17:00:00"), EndDateTime = DateTime.Parse("07/04/19 19:00:00"), MaxTickets = 3000, TicketsAvailable = 3000 },
            }.ForEach(a => context.Events.Add(a));
        }
    }
}
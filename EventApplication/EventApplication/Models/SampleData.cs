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
                new Event { EventType = eventTypes.Single(e => e.Name == "Music"), Title = "Tuba Christmas 2018", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = DateTime.Parse("12/09/18"), EndDate = DateTime.Parse("12/09/18"), StartTime = DateTime.Parse("11:00:00"), EndTime = DateTime.Parse("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                new Event { EventType = eventTypes.Single(e => e.Name == "Music"), Title = "Tuba Christmas 2017", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = DateTime.Parse("12/09/17"), EndDate = DateTime.Parse("12/09/17"), StartTime = DateTime.Parse("11:00:00"), EndTime = DateTime.Parse("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                new Event { EventType = eventTypes.Single(e => e.Name == "Music"), Title = "Tuba Christmas 2016", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = DateTime.Parse("12/09/16"), EndDate = DateTime.Parse("12/09/16"), StartTime = DateTime.Parse("11:00:00"), EndTime = DateTime.Parse("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                new Event { EventType = eventTypes.Single(e => e.Name == "Music"), Title = "Tuba Christmas 2015", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = DateTime.Parse("12/09/15"), EndDate = DateTime.Parse("12/09/15"), StartTime = DateTime.Parse("11:00:00"), EndTime = DateTime.Parse("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                new Event { EventType = eventTypes.Single(e => e.Name == "Music"), Title = "Tuba Christmas 2014", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = DateTime.Parse("12/09/14"), EndDate = DateTime.Parse("12/09/14"), StartTime = DateTime.Parse("11:00:00"), EndTime = DateTime.Parse("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                new Event { EventType = eventTypes.Single(e => e.Name == "Music"), Title = "Orchestra Concert", Description = "University of Akron's orchestra plays Mozart",
                    Organizer = "University of Akron", ContactInfo = "UofAOrchestra.net", City = "Akron", State = "OH",
                    StartDate = DateTime.Parse("05/01/19"), EndDate = DateTime.Parse("05/01/19"),
                    StartTime = DateTime.Parse("11:00:00"), EndTime = DateTime.Parse("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },

                new Event { EventType = eventTypes.Single(e => e.Name == "Outdoor Festivals"), Title = "Parade the Circle", Description = "Annual parade featuring local and national artists",
                    Organizer = "Cleveland Museum of Art", ContactInfo = "clevelandart.org", City = "Cleveland", State = "OH",
                    StartDate = DateTime.Parse("06/09/19"), EndDate = DateTime.Parse("06/09/19"),
                    StartTime = DateTime.Parse("10:00:00"), EndTime = DateTime.Parse("04:00:00"), MaxTickets = 14000, TicketsAvailable = 14000 },

                new Event { EventType = eventTypes.Single(e => e.Name == "Dance"), Title = "Swing Dance Party", Description = "A fun night of dancing. Lessons available for beginners!",
                    Organizer = "Suzie Smith", ContactInfo = "216-555-1412", City = "Akron", State = "OH",
                    StartDate = DateTime.Parse("05/05/19"), EndDate = DateTime.Parse("05/05/19"),
                    StartTime = DateTime.Parse("19:00:00"), EndTime = DateTime.Parse("23:00:00"), MaxTickets = 60, TicketsAvailable = 60 },

                new Event { EventType = eventTypes.Single(e => e.Name == "Dance"), Title = "Retro Dance Night", Description = "Dance to the hits of the 50s through 90s",
                    Organizer = "Robert Smith", ContactInfo = "440-555-6212", City = "Cleveland", State = "OH",
                    StartDate = DateTime.Parse("05/06/19"), EndDate = DateTime.Parse("05/06/19"),
                    StartTime = DateTime.Parse("17:00:00"), EndTime = DateTime.Parse("23:00:00"), MaxTickets = 150, TicketsAvailable = 150 },

                new Event { EventType = eventTypes.Single(e => e.Name == "Music"), Title = "Mr. B Jazz Trio", Description = "Acclaimed jazz musicians playing their latest songs",
                    Organizer = "Nighttown", ContactInfo = "MrB@jazz.net", City = "Cleveland", State = "OH",
                    StartDate = DateTime.Parse("05/05/19"), EndDate = DateTime.Parse("05/05/19"),
                    StartTime = DateTime.Parse("21:00:00"), EndTime = DateTime.Parse("23:00:00"), MaxTickets = 100, TicketsAvailable = 100 },


            }.ForEach(a => context.Events.Add(a));
        }
    }
}
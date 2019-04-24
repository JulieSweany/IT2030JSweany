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
                new EventType { Name = "Lectures" },
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
                new Event { EventTypeId = 1, Title = "Disco Inferno", Description = "Dance the night away to all your favorite disco hits", Organizer = "Disco Stu", ContactInfo = "216-555-1978", City = "Cleveland", State = "OH", StartDate = ("06/12/19"), EndDate = ("06/12/19"), StartTime = ("19:00:00"), EndTime = ("21:00:00"), MaxTickets = 100, TicketsAvailable = 100 },
                new Event { EventTypeId = 1, Title = "The Nutcracker", Description = "A holiday tradition", Organizer = "Miami Ballet", ContactInfo = "info@miamiballet.org", City = "Miami", State = "FL", StartDate = ("12/12/17"), EndDate = ("12/12/17"), StartTime = ("19:00:00"), EndTime = ("21:00:00"), MaxTickets = 1000, TicketsAvailable = 32 },
                new Event { EventTypeId = 2, Title = "Lakewood Project July 4 Concert", Description = "Rock Orchestra plays classic hits at outdoor concert", Organizer = "Lakewood City Schools", ContactInfo = "OneLakewood.com", City = "Lakewood", State = "OH", StartDate = ("07/04/19"), EndDate = ("07/04/19"), StartTime = ("19:00:00"), EndTime = ("21:30:00"), MaxTickets = 3000, TicketsAvailable = 3000 },
                new Event { EventTypeId = 2, Title = "Tuba Christmas 2019", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = ("12/10/19"), EndDate = ("12/10/19"), StartTime = ("11:00:00"), EndTime = ("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                new Event { EventTypeId = 2, Title = "Tuba Christmas 2018", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = ("12/09/18"), EndDate = ("12/09/18"), StartTime = ("11:00:00"), EndTime = ("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                new Event { EventTypeId = 2, Title = "Tuba Christmas 2017", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDate = ("12/08/17"), EndDate = ("12/08/17"), StartTime = ("11:00:00"), EndTime = ("01:00:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                new Event { EventTypeId = 2, Title = "Mr. B Jazz Trio", Description = "Acclaimed jazz trio plays songs from latest release", Organizer = "Nighttown", ContactInfo = "someone@nighttown.com", City = "Cleveland", State = "OH", StartDate = ("05/12/19"), EndDate = ("05/12/19"), StartTime = ("20:00:00"), EndTime = ("22:00:00"), MaxTickets = 200, TicketsAvailable = 200 },
                new Event { EventTypeId = 3, Title = "E. 22nd St. Fair", Description = "Block party with food, music, games and fun", Organizer = "Downtown Development Corp", ContactInfo = "downtownlansind.com", City = "Lansing", State = "MI", StartDate = ("06/10/19"), EndDate = ("06/14/19"), StartTime = ("11:00:00"), EndTime = ("23:00:00"), MaxTickets = 800, TicketsAvailable = 160 },
                new Event { EventTypeId = 3, Title = "Parade the Circle", Description = "Cleveland Museum of Art's annual parade and community festival", Organizer = "Cleveland Museum of Art", ContactInfo = "clevelandart.org", City = "Cleveland", State = "OH", StartDate = ("06/09/19"), EndDate = ("06/09/19"), StartTime = ("10:00:00"), EndTime = ("16:00:00"), MaxTickets = 12000, TicketsAvailable = 11235 },
                new Event { EventTypeId = 3, Title = "NYE Beach Party", Description = "Ring in the New Year on the beach", Organizer = "City of Miami", ContactInfo = "Y2KNYEMiami.net", City = "Miami", State = "FL", StartDate = ("12/31/09"), EndDate = ("01/01/10"), StartTime = ("20:00:00"), EndTime = ("03:00:00"), MaxTickets = 1000, TicketsAvailable = 35 },
                new Event { EventTypeId = 14, Title = "Cross Country Skiing Lesson", Description = "Learn the basics and enjoy the outdoors this winter", Organizer = "Cleveland Metroparks", ContactInfo = "216-555-2365", City = "Cleveland", State = "OH", StartDate = ("01/11/18"), EndDate = ("01/11/18"), StartTime = ("11:00:00"), EndTime = ("01:00:00"), MaxTickets = 30, TicketsAvailable = 2 },

                //new Event { EventTypeId = 1, Title = "Disco Inferno", Description = "Dance the night away to all your favorite disco hits", Organizer = "Disco Stu", ContactInfo = "216-555-1978", City = "Cleveland", State = "OH", StartDateTime = DateTime.Parse("06/12/19 19:00:00"), EndDateTime = DateTime.Parse("06/12/19 21:00:00"), MaxTickets = 100, TicketsAvailable = 100 },
                //new Event { EventTypeId = 2, Title = "Lakewood Project July 4 Concert", Description = "Rock Orchestra plays classic hits at outdoor concert", Organizer = "Lakewood City Schools", ContactInfo = "OneLakewood.com", City = "Lakewood", State = "OH", StartDateTime = DateTime.Parse("07/04/19 19:00:00"), EndDateTime = DateTime.Parse("07/04/19 19:00:00"), MaxTickets = 3000, TicketsAvailable = 3000 },
                //new Event { EventTypeId = 2, Title = "Tuba Christmas", Description = "Tubas bring Christmas cheer", Organizer = "University of Akron", ContactInfo = "TubaChristmas.com", City = "Akron", State = "OH", StartDateTime = DateTime.Parse("12/10/19 11:00:00"), EndDateTime = DateTime.Parse("12/10/19 13:30:00"), MaxTickets = 2000, TicketsAvailable = 2000 },
                //new Event { EventTypeId = 2, Title = "Mr. B Jazz Trio", Description = "Acclaimed jazz trio plays songs from latest release", Organizer = "Nighttown", ContactInfo = "someone@nighttown.com", City = "Cleveland", State = "OH", StartDateTime = DateTime.Parse("05/10/19 20:00:00"), EndDateTime = DateTime.Parse("05/10/19 23:30:00"), MaxTickets = 200, TicketsAvailable = 200 },
         
                //new Event { EventTypeId = eventTypes.Single(e => e.Name == "Dance").EventTypeId, Title = "Disco Inferno", Description = "Dance the night away to all your favorite disco hits", Organizer = "Disco Stu", ContactInfo = "216-555-1978", City = "Cleveland", State = "OH", StartDateTime = DateTime.Parse("06/12/19 19:00:00"), EndDateTime = DateTime.Parse("06/12/19 21:00:00"), MaxTickets = 100, TicketsAvailable = 100 },
                //new Event { EventTypeId = eventTypes.Single(e => e.Name == "Music").EventTypeId, Title = "Lakewood Project July 4 Concert", Description = "Rock Orchestra plays classic hits at outdoor concert", Organizer = "Lakewood City Schools", ContactInfo = "OneLakewood.com", City = "Lakewood", State = "OH", StartDateTime = DateTime.Parse("07/04/19 17:00:00"), EndDateTime = DateTime.Parse("07/04/19 19:00:00"), MaxTickets = 3000, TicketsAvailable = 3000 },
            }.ForEach(a => context.Events.Add(a));
        }
    }
}


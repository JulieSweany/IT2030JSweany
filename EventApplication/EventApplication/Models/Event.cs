using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Event
    {
        public virtual int EventId { get; set; }
        public virtual int EventTypeId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime StartDateTime { get; set; }
        public virtual DateTime EndDateTime { get; set; }
        public virtual string Organizer { get; set; }
        public virtual string ContactInfo { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual int MaxTickets { get; set; }
        public virtual int TicketsAvailable { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Event
    {
        //[Required(ErrorMessage = "The Student's {0} is required")]
        //[StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        //[Display(Name = "First Name")]

        public virtual int EventId { get; set; }
        public virtual int EventTypeId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }

        [Display(Name = "Start Date")]
        public virtual string StartDate { get; set; }

        [Display(Name = "Start Time")]
        public virtual string StartTime { get; set; }

        [Display(Name = "End Date")]
        public virtual string EndDate { get; set; }

        [Display(Name = "End Time")]
        public virtual string EndTime { get; set; }

        public virtual string Organizer { get; set; }

        [Display(Name = "Organizer Contact Info")]
        public virtual string ContactInfo { get; set; }

        public virtual string City { get; set; }
        public virtual string State { get; set; }

        [Display(Name = "Max Tickets")]
        public virtual int MaxTickets { get; set; }

        [Display(Name = "Available Tickets")]
        public virtual int TicketsAvailable { get; set; }
    }
}
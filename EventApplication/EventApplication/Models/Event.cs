using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class Event
    {
        public virtual int EventId { get; set; }

        [Display(Name = "Event Type")]
        public virtual int EventTypeId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }

        [Display(Name = "Start Date")]
        //[DateInFuture()]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public virtual DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        //[DateInFuture()]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public virtual DateTime EndDate { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        [DataType(DataType.Time)]
        [Display(Name = "Start Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:h:mm tt}")]
        public virtual DateTime StartTime { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        [DataType(DataType.Time)]
        [Display(Name = "End Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:h:mm tt}")]
        public virtual DateTime EndTime { get; set; }

        [Display(Name = "Organizer Name")]
        [Required(ErrorMessage = "The {0} is required")]
        public virtual string Organizer { get; set; }

        [Display(Name = "Organizer Contact Info")]
        public virtual string ContactInfo { get; set; }

        public virtual string City { get; set; }
        public virtual string State { get; set; }

        [Display(Name = "Max Tickets")]
        [Range(1, Double.PositiveInfinity, ErrorMessage = "The quantity for {0} must be at least 1")]
        public virtual int MaxTickets { get; set; }

        [Display(Name = "Available Tickets")]
        [Range(1,Double.PositiveInfinity, ErrorMessage = "The quantity for {0} must be at least 1")]
        public virtual int TicketsAvailable { get; set; }

        public virtual EventType EventType { get; set; }
    }
}

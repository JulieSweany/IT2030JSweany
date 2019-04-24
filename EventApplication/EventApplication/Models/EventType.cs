using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class EventType
    {
        //[Required(ErrorMessage = "The Student's {0} is required")]
        //[StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        //[Display(Name = "First Name")]

        [Display(Name = "Event Type ID")]
        public virtual int EventTypeId { get; set; }

        [Display(Name = "Event Type")]
        public virtual string Name { get; set; }
    }
}
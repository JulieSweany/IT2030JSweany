using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class EventType
    {
        [Display(Name = "Event Type")]
        public virtual int EventTypeId { get; set; }

        [Display(Name = "Event Type")]
        public virtual string Name { get; set; }

    }
}

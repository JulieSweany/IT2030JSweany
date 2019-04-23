using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class EventType
    {
        public virtual int EventTypeId { get; set; }
        public virtual string Name { get; set; }
    }
}
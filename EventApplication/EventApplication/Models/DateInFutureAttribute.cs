using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class DateInFutureAttribute : ValidationAttribute
    {
        public DateInFutureAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if ((DateTime)value < DateTime.Now)
                {
                     return new ValidationResult("Date must be in the future");
                }
            }

            return ValidationResult.Success;
        }
    }
}
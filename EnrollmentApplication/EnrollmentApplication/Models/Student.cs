using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models 
{
    public class Student : IValidatableObject
    {
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Required(ErrorMessage = "The Student's {0} is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        [Display(Name = "Last Name")]
        public virtual string LastName { get; set; }

        [Required(ErrorMessage = "The Student's {0} is required")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        [Display(Name = "First Name")]
        public virtual string FirstName { get; set; }

        [MinimumAge(20)]
        public virtual int Age { get; set; }

        [Required(ErrorMessage = "The Address is required")]
        [Display(Name = "Address 1")]
        public virtual string Address1 { get; set; }

        [Required(ErrorMessage = "A second Address is required")]
        [Display(Name = "Address 2")]
        public virtual string Address2 { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        public virtual string City { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        public virtual string Zipcode { get; set; }

        [Required]
        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Address1 == Address2)
            {
                yield return new ValidationResult("Address 2 cannot be the same as Address 1");
            }

            if (State.Length != 2)
            {
                yield return new ValidationResult("Enter a 2 digit State code");
            }

            if (Zipcode.Length != 5)
            {
                yield return new ValidationResult("Enter a 5 digit Zipcode");
            }

        }
    }
}

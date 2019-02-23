using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        [StringLength(150, ErrorMessage = "Course Title cannot exceed 150 characters")]
        [Display(Name = "Course Title")]
        public virtual string CourseTitle { get; set; }

        [Display(Name = "Description")]
        public virtual string CourseDescription { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        [Range(1,4, ErrorMessage = "Please enter a number from 1 through 4")]
        [Display(Name = "Number of Credits")]
        public virtual int Credits { get; set; }
    }
}
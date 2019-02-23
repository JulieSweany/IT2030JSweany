using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        [Display(Name = "Enrollment ID")]
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "The Grade is required")]
        [RegularExpression(@"[A-F]", ErrorMessage = "Acceptable Grades are: A, B, C, D, E, or F")]
        public virtual string Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        [Display(Name = "Is Active")]
        public virtual bool IsActive { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required(ErrorMessage = "The Semester is required")]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        [Range(2018,3000, ErrorMessage = "Years before 2018 are not allowed")]
        [Display(Name = "Enrollment Year")]
        public virtual int EnrollmentYear { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        //create string that holds invalid characters
        readonly string invalidChars;

        public InvalidCharsAttribute(string invalidChars)
        {
            this.invalidChars = invalidChars;
        }
        //object value is the value passed in through the parameter; validation context refers to the field that parameter is attached to
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                //put string of invalid characters (invalidChars) into character array
                char[] invalidArray = new char[invalidChars.Length];//creates array names invalidArray
                invalidChars.CopyTo(0, invalidArray, 0, invalidArray.Length);//puts values from string into array

                //valueAsString is the text entered into the field//invalidChars is the argument in the method's parameter in the model
                var valueAsString = value.ToString();

                //if the index of the invalid char within the string > -1
                if (valueAsString.IndexOfAny(invalidArray) > -1)
                {
                    return new ValidationResult("Notes contains unacceptable characters!");
                }
            }
            return ValidationResult.Success;
        }
    }

}

//Code that worked when checking a single character passed in
/*
namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        //create string that holds invalid characters
        readonly string invalidChars;

        public InvalidCharsAttribute(string invalidChars)
        {
            this.invalidChars = invalidChars;
        }
        //object value is the value passed in through the parameter; validation context refers to the field that parameter is attached to
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                //valueAsString is the text entered into the field//invalidChars is the argument in the method's parameter in the model
                var valueAsString = value.ToString();

                //if the index of the invalid char within the string > -1
                if (valueAsString.IndexOf(invalidChars) > -1) 
                {
                    return new ValidationResult("Error");
                }
            }
            return ValidationResult.Success;
        }
    }

}
*/

/*
//This works with multiple special characters passed in
protected override ValidationResult IsValid(object value, ValidationContext validationContext)
{
    if (value != null)
    {
        //put string of invalid characters (invalidChars) into character array
        char[] invalidArray = new char[invalidChars.Length];//creates array names invalidArray
        invalidChars.CopyTo(0, invalidArray, 0, invalidArray.Length);//puts values from string into array

        //valueAsString is the text entered into the field//invalidChars is the argument in the method's parameter in the model
        var valueAsString = value.ToString();

        //if the index of the invalid char within the string > -1
        if (valueAsString.IndexOfAny(invalidArray) > -1)
        {
            return new ValidationResult("Error");
        }
    }
    return ValidationResult.Success;
}

    */
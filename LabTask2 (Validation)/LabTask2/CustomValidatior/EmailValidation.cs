using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabTask2.CustomValidatior
{
    public class EmailValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string email = value.ToString();
                if (email.EndsWith("@student.aiub.edu"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Invalid Email");
        }

    }
}
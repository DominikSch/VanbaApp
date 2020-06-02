using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace VanbaApp.Models
{
    public class VanbaValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string text = value.ToString();

            if (Regex.IsMatch(text, @"^([sdbgvmnylaiu]*|(ai)*|(oi)*)+$", RegexOptions.IgnoreCase))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Bitte nur Vanba Buchstaben verwenden");
            }

        }
    }
}
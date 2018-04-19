using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinalAssignmentSDT
{
    class TextBoxValidationRule : ValidationRule
    {
        private string regex;
        private string errorMessage;
        private string minLength;
        

        public string Regex { get => regex; set => regex = value; }
        public string ErrorMessage { get => errorMessage; set => errorMessage = value; }
        public string MinLength { get => minLength; set => minLength = value; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex rule = new Regex(regex);
            ValidationResult result = new ValidationResult(true, null);
            string inputString = (value ?? string.Empty).ToString();
            
            if (inputString == null || inputString == "")
            {
                result = new ValidationResult(false, "Value cannot be empty");
            }
            else if (!rule.IsMatch(inputString))
            {
                result = new ValidationResult(false, this.ErrorMessage);
            }
            else if (inputString.Length<int.Parse(minLength))
            {
                result = new ValidationResult(false, "Entered value cannot be less then " + minLength + " characters");
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinalAssignmentSDT
{
    class ComboBoxValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result;

            if (value == null || (value is string && string.IsNullOrEmpty(value as string)))
            {
                result = new ValidationResult(false, "Please chose one of the options");
            }
            else
            {
                result = new ValidationResult(true, null);
            }

            return result;

        }
    }
}

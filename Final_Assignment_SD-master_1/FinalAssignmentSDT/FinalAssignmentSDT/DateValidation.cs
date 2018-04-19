using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinalAssignmentSDT
{
    class DateValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result = new ValidationResult(true, null);
            DateTime appointmentDate = (DateTime)value;
            if (appointmentDate < DateTime.Now)
            {
                result = new ValidationResult(false, "Please pick future date");
            }
            return result;
        }
    }
}

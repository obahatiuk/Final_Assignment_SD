using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentSDT
{
    interface IFirm
    {
        bool PreviousCustomer { get; set; }
        string TokenNo { get; set; }
        int Fees { get; set; }
        string CustomerRegistration();
        int EstimatedProcessingHours();
        bool CustomerEligibleForDiscount();

    }
}

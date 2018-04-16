using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentSDT
{
    abstract class Firm : IFirm
    {
        private bool previousCustomer;
        private string tokenNo;
        private int fees;

        public bool PreviousCustomer { get => previousCustomer; set => previousCustomer = value; }
        public string TokenNo { get => tokenNo; set => tokenNo = value; }
        public int Fees { get => fees; set => fees = value; }

        public abstract bool CustomerEligibleForDiscount();
        

        public string CustomerRegistration()
        {
            throw new NotImplementedException();
        }

        public int EstimatedProcessingHours()
        {
            throw new NotImplementedException();
        }
    }
}

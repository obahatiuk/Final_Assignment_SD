using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentSDT
{
    class ITConsultancy : Firm
    {
        public ITConsultancy()
        {
                
        }
        public ITConsultancy(bool previousCustomer,string tokenNo,int fees)
        {
            PreviousCustomer = previousCustomer;
            TokenNo = tokenNo;
            Fees = fees;
        }

        public override bool CustomerEligibleForDiscount()
        {
            throw new NotImplementedException();
        }
        
    }
}

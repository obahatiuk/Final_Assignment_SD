using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentSDT
{
    public class Firm //: IFirm
    {

        private static Dictionary<string, Dictionary<string, List<string>>> firm ;

        public static Dictionary<string, Dictionary<string, List<string>>> Firm_ {
            get
            {
                firm = new Dictionary<string, Dictionary<string, List<string>>>();
                firm.Add("Individual", new Dictionary<string, List<string>>());
                firm.Add("Corporate", new Dictionary<string, List<string>>());
                firm["Individual"].Add("Investment", new List<string> { "Kitchener", "Waterloo" });
                firm["Corporate"].Add("Investment", new List<string> { "Brantford","Toronto" });
                firm["Individual"].Add("Taxation", new List<string> { "Stranford","Mississauga" });
                firm["Corporate"].Add("Taxation", new List<string> { "Vaughan","Cambridge" });
                firm["Individual"].Add("Law", new List<string> { "Kingston", "Barrie", "Guelph" });
                firm["Corporate"].Add("Law", new List<string> { "Cambridge", "Kitchener", "Waterloo" });
                
                return firm;
            }
        }

        //private bool previousCustomer;
        //private string tokenNo;
        //private int fees;

        //public bool PreviousCustomer { get => previousCustomer; set => previousCustomer = value; }
        //public string TokenNo { get => tokenNo; set => tokenNo = value; }
        //public int Fees { get => fees; set => fees = value; }

        //public abstract bool CustomerEligibleForDiscount();


        //public string CustomerRegistration()
        //{
        //    throw new NotImplementedException();
        //}

        //public int EstimatedProcessingHours()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

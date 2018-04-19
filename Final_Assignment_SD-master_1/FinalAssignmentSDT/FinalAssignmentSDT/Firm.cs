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
                firm["Corporate"].Add("Investment", new List<string> { "Waterloo" });
                firm["Individual"].Add("Taxation", new List<string> { "Waterloo" });
                firm["Corporate"].Add("Taxation", new List<string> { "Kitchener" });
                firm["Individual"].Add("Law", new List<string> { "Cambridge", "Kitchener", "Waterloo" });
                firm["Corporate"].Add("Law", new List<string> { "Cambridge", "Kitchener", "Waterloo" });
                //firm.Add("Kitchener", new Dictionary<string,  List<string>>());
                //firm.Add("Waterloo", new Dictionary<string, List<string>>());
                //firm.Add("Cambridge", new Dictionary<string, List<string>>());

                //firm["Kitchener"].Add("Individual", new List<string> {"Investment","Taxation","Law" });
                //firm["Kitchener"].Add("Corporate", new List<string> {  "Law" });

                //firm["Waterloo"].Add("Individual", new List<string> { "Investment", "Law" });
                //firm["Waterloo"].Add("Corporate", new List<string> { "Investment", "Law" });

                //firm["Cambridge"].Add("Individual", new List<string> {  "Law" });
                //firm["Cambridge"].Add("Corporate", new List<string> { "Investment", "Taxation", "Law" });

                //firm["Kitchener"]["Individual"];
                //firm["Kitchener"]["Corporate"];
                //firm["Waterloo"]["Individual"];
                //firm["Waterloo"]["Corporate"];
                //firm["Cambridge"]["Individual"];
                //firm["Cambridge"]["Corporate"];

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

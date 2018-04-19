using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentSDT
{
    public class Customer : ICloneable
    {
        private string firstName;
        private string phone;
        
        public Customer(){}

        public Customer(string firstName, string phone)
        {
            this.firstName = firstName;
            this.phone = phone;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string Phone { get => phone; set => phone = value; }

        public object Clone()
        {
            Customer customer = new Customer();
            customer.firstName = this.firstName;
            customer.phone = this.phone;
            return customer;
        }
    }
}

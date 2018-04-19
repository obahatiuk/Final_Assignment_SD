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
        private string lastName;
        private string phone;
        private string address1;
        private string address2;
        private string city;
        private string postalCode;

        public Customer(){}

        public Customer(string firstName, string lastName, string phone, string address1, string address2, string city, string postalCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.postalCode = postalCode;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address1 { get => address1; set => address1 = value; }
        public string Address2 { get => address2; set => address2 = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }

        public object Clone()
        {
            Customer customer = new Customer();
            customer.firstName = this.firstName;
            customer.lastName = this.lastName;
            customer.phone = this.phone;
            customer.address1 = this.address1;
            customer.address2 = this.address2;
            customer.city = this.city;
            customer.postalCode = this.postalCode;
            return customer;
        }
    }
}

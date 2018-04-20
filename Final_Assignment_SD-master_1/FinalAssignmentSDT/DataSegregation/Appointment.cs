using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentSDT
{
    public partial class Appointment : ICloneable
    {
        private int id;
        private string time;
        private string typeOfCustomer;
        private string service;
        private Customer customer;
        private DateTime date;
        private string department;


        public Appointment() {}

        public Appointment(int id,string time,  string typeOfCustomer, string service, Customer customer, DateTime date, string department)
        {
            this.id = id;
            this.date = date;
            this.time = time;
            this.department = department;
            this.typeOfCustomer = typeOfCustomer;
            this.service = service;
            this.customer = customer;
        }

        public int Id { get => id; set => id = value; }
        public string Time { get => time; set => time = value; }
        public string TypeOfCustomer { get => typeOfCustomer; set => typeOfCustomer = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public DateTime Date { get => date; set => date = value.Date; }
        public string Department { get => department; set => department = value; }
        public string Service { get => service; set => service = value; }

        public object Clone()
        {
            Appointment appointment = new Appointment();
            appointment.id = this.id;
            appointment.time = this.time;
            appointment.date = this.date.Date;
            appointment.department = this.department;
            appointment.typeOfCustomer = this.typeOfCustomer;
            appointment.service = this.service;
            appointment.customer = (Customer)this.customer.Clone();
            return appointment;
        }
    }
}

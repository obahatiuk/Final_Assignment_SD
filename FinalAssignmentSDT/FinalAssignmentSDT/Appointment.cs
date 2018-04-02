using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentSDT
{
    class Appointment
    {
        private int id;
        private string time;
        private string day;
        private string type;

        public Appointment() {
        }

        public Appointment(int id, string time, string day, string type)
        {
            this.Id = id;
            this.Time = time;
            this.Day = day;
            this.Type = type;
        }

        public int Id { get => id; set => id = value; }
        public string Time { get => time; set => time = value; }
        public string Day { get => day; set => day = value; }
        public string Type { get => type; set => type = value; }
    }
}

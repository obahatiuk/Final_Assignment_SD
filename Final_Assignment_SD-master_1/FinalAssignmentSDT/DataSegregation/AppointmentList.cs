using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinalAssignmentSDT
{
    [XmlRoot("AppointmentList")]
    public class AppointmentList
    {
        [XmlArray("Appointments")]
        [XmlArrayItem("Appointment")]
        public ObservableCollection<Appointment> Appointments;
    }
}

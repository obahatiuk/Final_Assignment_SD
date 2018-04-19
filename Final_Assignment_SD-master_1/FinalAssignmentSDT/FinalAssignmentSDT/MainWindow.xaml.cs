using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;

namespace FinalAssignmentSDT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private ObservableCollection<Appointment> appointmentsList;
        public ObservableCollection<Appointment> AppointmentsList { get => appointmentsList; set => appointmentsList = value; }
        private ObservableCollection<Appointment> appointmentsListXML;
        public ObservableCollection<Appointment> AppointmentsListXML { get => appointmentsListXML; set => appointmentsListXML = value; }
        private ObservableCollection<string> slots;
        
        private List<string> typesOfClient;
        private ObservableCollection<string> services;
        private ObservableCollection<string> departments;
        private Appointment tempAppointment;
        private DateTime Date;

        public Dictionary<DateTime, List<string>> arrangedTime = new Dictionary<DateTime, List<string>>();
        private Firm firm = new Firm();
        public List<string> availableSlots = new List<string>() { "AM9", "AM11", "PM1", "PM3", "PM5" };

        public Appointment TempAppointment { get => tempAppointment; set => tempAppointment = value; }
        public List<string> TypesOfClient { get => typesOfClient; set => typesOfClient = value; }
        public ObservableCollection<string> Services { get => services; set => services = value; }
        public ObservableCollection<string> Departments { get => departments; set => departments = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
        public ObservableCollection<string> Slots { get => slots; set => slots = value; }

        public MainWindow()

        {
            
            InitializeComponent();
            
            DataContext = this;
            tempAppointment = new Appointment();
            tempAppointment.Customer = new Customer();
            tempAppointment.Date = DateTime.Today.AddDays(1); 
            Dictionary<string, Dictionary<string, List<string>>> serviceDetails = Firm.Firm_;
            Dictionary<string, Dictionary<string, List<string>>>.KeyCollection keyColl = serviceDetails.Keys;

            List<string> typesOfClients = new List<string>();
            foreach (string typeOfClient in keyColl)
            {
                typesOfClients.Add(typeOfClient);
            }

            this.TypesOfClient = typesOfClients;

            Services = new ObservableCollection<string>();
            Departments = new ObservableCollection<string>();
            appointmentsList = new ObservableCollection<Appointment>();
            appointmentsListXML = new ObservableCollection<Appointment>();
            Slots = new ObservableCollection<string>();
            ReadFromXML();
            foreach (Appointment a in appointmentsList.ToList())
            {
                appointmentsList.Remove(a);
            }

            foreach (Appointment a in appointmentsListXML)
            {


                bool contains = !(appointmentsList.Contains(a));
                if (contains)
                {
                    appointmentsList.Add(a);
                }
            }
            datagrid.Items.Refresh();



            DateTime dateOfTemporatyApointment = tempAppointment.Date;

            Dictionary<DateTime, List<string>>.KeyCollection arrangedDates = arrangedTime.Keys;
            foreach (Appointment appointment in appointmentsList)
            {
                arrangedDates = arrangedTime.Keys;
                if (arrangedDates.Contains(appointment.Date))
                {
                    if (arrangedTime[appointment.Date].Contains(appointment.Time))
                    {

                    }
                    else
                    {
                        arrangedTime[appointment.Date].Add(appointment.Time);
                    }
                }
                else
                {
                    arrangedTime.Add(appointment.Date, new List<string>());
                    arrangedTime[appointment.Date].Add(appointment.Time);
                }
            }
        }

        private void btnAdd(object sender, RoutedEventArgs e)

        {
            
        }

        private void btnDelete(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnUpdate(object sender, RoutedEventArgs e)
        {
            
        }

        private void cbTypeOfClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTypeOfClient.SelectedIndex != -1)
            {
                Dictionary<string, Dictionary<string, List<string>>> serviceDetails = Firm.Firm_;
                if (tempAppointment.TypeOfCustomer != null)
                {
                    Dictionary<string, List<string>>.KeyCollection keyColl = serviceDetails[tempAppointment.TypeOfCustomer].Keys;
                    List<string> typesOfServices = new List<string>();
                    foreach (string service in keyColl)
                    {
                        Services.Add(service);
                    }
                }
            }
        }

        private void cbService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbService.SelectedIndex != -1)
            {
                Dictionary<string, Dictionary<string, List<string>>> serviceDetails = Firm.Firm_;
                List<string> keyColl = serviceDetails[TempAppointment.TypeOfCustomer][tempAppointment.Service];

                foreach (string department in keyColl)
                {
                    Departments.Add(department);
                }
            }
            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            
            
            BindingExpression be = tbPhoneNumber.GetBindingExpression(TextBox.TextProperty);
            BindingExpression be1 = cbTime.GetBindingExpression(ComboBox.SelectedItemProperty);
            BindingExpression be2 = cbTypeOfClient.GetBindingExpression(ComboBox.SelectedItemProperty);
            BindingExpression be3 = cbService.GetBindingExpression(ComboBox.SelectedItemProperty);
            BindingExpression be4 = cbDepartment.GetBindingExpression(ComboBox.SelectedItemProperty);
            BindingExpression be5 = tbName.GetBindingExpression(TextBox.TextProperty);
            BindingExpression be6 = dpDate.GetBindingExpression(DatePicker.SelectedDateProperty);

            be.UpdateSource();
            be1.UpdateSource();
            be2.UpdateSource();
            be3.UpdateSource();
            be4.UpdateSource();
            be5.UpdateSource();
            be6.UpdateSource();

            if (Validation.GetErrors(tbName).Count() == 0
                && Validation.GetErrors(tbPhoneNumber).Count() == 0
                && Validation.GetErrors(cbDepartment).Count() == 0
                && Validation.GetErrors(cbService).Count() == 0
                && Validation.GetErrors(cbTime).Count() == 0
                && Validation.GetErrors(dpDate).Count() == 0
                )
            {
                DateTime dateOfTemporatyApointment = tempAppointment.Date;
                String slotOfTemporatyApointment = string.Copy(tempAppointment.Time);//
                Dictionary<DateTime, List<string>>.KeyCollection arrangedDates = arrangedTime.Keys;
                if (!arrangedDates.Contains(dateOfTemporatyApointment))
                {
                    arrangedTime.Add(dateOfTemporatyApointment, new List<string>());
                }

                arrangedTime[dateOfTemporatyApointment].Add(slotOfTemporatyApointment);


                Appointment a = (Appointment)tempAppointment.Clone();
                a.Id = appointmentsList.Count + 1;
                bool containsA = appointmentsList.ToList().Contains(a);
                if (!containsA)
                {
                    appointmentsList.Add(a);
                }
                WriteToXML();
                tempAppointment.Date = DateTime.Today.AddDays(1);
                dpDate.SelectedDate = DateTime.Today.AddDays(1);

                tbName.Text = "";
                tbPhoneNumber.Text = "";
                cbTime.SelectedIndex = -1;
                cbDepartment.SelectedIndex = -1;
                cbService.SelectedIndex = -1;
                cbTypeOfClient.SelectedIndex = -1;


                Services = new ObservableCollection<string>();
                Departments = new ObservableCollection<string>();

                Validation.ClearInvalid(be4);
                Validation.ClearInvalid(be1);
                Validation.ClearInvalid(be2);
                Validation.ClearInvalid(be3);
            }
            
                
            


        }

        private void dpDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            Dictionary<DateTime, List<string>>.KeyCollection arrangedDates = arrangedTime.Keys;
            List<string> copyOfSlots = new List<string>() { "AM9", "AM11", "PM1", "PM3", "PM5" };
            foreach (DateTime arrangedDate in arrangedDates)
            {
                if (arrangedDate == tempAppointment.Date)
                {
                    List<string> arrangedSlots = arrangedTime[TempAppointment.Date];
                    foreach (string slot in copyOfSlots.ToList())
                    {
                        if (arrangedSlots.Contains(slot))
                        {
                            copyOfSlots.Remove(slot);
                        }
                    }
                }
            }
            
            foreach (string slot in Slots.ToList())
            {
                Slots.Remove(slot);
            }
            foreach (string slot in copyOfSlots)
            {
                Slots.Add(slot);
            }
        }
        
        private void WriteToXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Appointment>));
            TextWriter writer = new StreamWriter("appointments.xml");
            serializer.Serialize(writer, appointmentsList);
            writer.Close();
        }

        private void ReadFromXML()
        {
            string path = "appointments.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Appointment>));
            StreamReader reader = new StreamReader(path);
            appointmentsListXML = (ObservableCollection<Appointment>)serializer.Deserialize(reader);
            reader.Close();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            ReadFromXML();
            foreach (Appointment a in appointmentsList.ToList())
            {
                appointmentsList.Remove(a);
            }

                foreach (Appointment a in appointmentsListXML)
            {
                

                bool contains = !(appointmentsList.Contains(a));
                if (contains)
                {
                    appointmentsList.Add(a);
                }
            }
            datagrid.Items.Refresh();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ReadFromXML();
            
            string selectedColumn = cbFilter.SelectedItem as string;
            List<string> items = new List<string>();

            foreach (Appointment appointment in AppointmentsList)
            {
                string value;
                if (selectedColumn == "All")
                {
                    value = "";
                }
                else if (selectedColumn == "Name")
                {
                    Customer x = appointment.Customer;
                    string[] properties = selectedColumn.Split('.');
                    value = x.GetType().GetProperty("FirstName").GetValue(x).ToString();
                }
                else if (selectedColumn == "Date")
                {
                    value = appointment.GetType().GetProperty(selectedColumn).GetValue(appointment).ToString().Substring(0, 10);
                }
                else
                {
                    value = appointment.GetType().GetProperty(selectedColumn).GetValue(appointment).ToString();
                }

                if (items.IndexOf(value) == -1)
                {
                    items.Add(value);
                }
            }

            cbFilterValue.ItemsSource = items;
            cbFilterValue.Items.Refresh();
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            cbFilter.Items.Add("All");
            
            foreach (DataGridColumn column in datagrid.Columns.ToList())
            {
                
                string s = column.Header.ToString();
                cbFilter.Items.Add(s);
            }
            cbFilter.SelectedItem = "All";
        }

        private void cbFilterValue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ReadFromXML();
            Appointment appointment = new Appointment();
            string propertyName = "" + cbFilter.SelectedValue as string;
            string propertyValue = cbFilterValue.SelectedValue as string;
            List<Appointment> queryA = new List<Appointment>();
            if (propertyName == "All")
            {
                var query = from app in AppointmentsList
                            select app;

                foreach (Appointment a in query)
                {
                    queryA.Add(a);
                }
            }
            else if (propertyName == "Name")
            {
                appointment = AppointmentsList[0];
                Customer customerQ = appointment.Customer;
                string[] properties = propertyName.Split('.');
                PropertyInfo[] prop = AppointmentsList[0].GetType().GetProperties();
                PropertyInfo property = customerQ.GetType().GetProperty("FirstName");
                var query = from app in AppointmentsList
                            where property.GetValue(app.Customer) == propertyValue
                            select app;
                foreach (Appointment a in query)
                {
                    queryA.Add(a);
                }
            }
            else if (propertyName == "Date")
            {
                PropertyInfo property = appointment.GetType().GetProperty(propertyName);
                var query = from app in AppointmentsList
                            where app.Date.ToString().Substring(0,10) == propertyValue
                            select app;
                foreach (Appointment a in query)
                {
                    queryA.Add(a);
                }
            }
            else
            {
                PropertyInfo property = appointment.GetType().GetProperty(propertyName);
                var query = from app in AppointmentsList
                            where property.GetValue(app) == propertyValue
                            select app;
                foreach (Appointment a in query)
                {
                    queryA.Add(a);
                }
            }

            List<Appointment> items = new List<Appointment>();
            foreach (Appointment i in queryA)
            {
                string time = i.Time;
                items.Add(i);
            }
            datagrid.ItemsSource = items;
            datagrid.Items.Refresh();
        }

        
    } 
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace FinalAssignmentSDT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    
        ObservableCollection<Appointment> appointmentList;

        public MainWindow()

        {
            InitializeComponent();
            appointmentList = new ObservableCollection<Appointment>();
            appointmentList.Add(new Appointment() { Id  =1, Day="Monday",  Time="5:00", Type="Casual" });
            appointmentList.Add(new Appointment() { Id = 2, Day = "Tuesday", Time = "6:00", Type = "Normal" });
            appointmentList.Add(new Appointment() { Id = 3, Day = "Wednesday", Time = "7:00", Type = "Casual" });
            appointmentList.Add(new Appointment() { Id = 4, Day = "Thursday", Time = "8:00", Type = "Normal" });
            datagrid.ItemsSource = appointmentList;
            datagrid.ColumnWidth = 220;

        }

        private void btnAdd(object sender, RoutedEventArgs e)

        {
            int id = 0;
            try
            {
                id = int.Parse(txtID.Text.Trim());
                appointmentList.Add(new Appointment() { Id = id, Day = txtDay.Text.Trim(), Time = txtTime.Text.Trim(),Type=txtAppointmentType.Text.Trim() });
            }
            catch
            {
                MessageBox.Show("ID must be int type");
            }

        }

        private void btnDelete(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedIndex >= 0)
            {
                
                Appointment appointment = datagrid.SelectedItem as Appointment;
                appointmentList.Remove(appointment);
            }
        }



        private void btnUpdate(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedIndex >= 0)
            {
                // get the selected's infomation first
                Appointment newAppointment = new Appointment();
                newAppointment.Id = int.Parse(txtShowID.Text);
                newAppointment.Day = txtShowDay.Text.Trim();
                newAppointment.Time = txtShowTime.Text.Trim();
                newAppointment.Type = txtShowAppointmentType.Text.Trim();
                // remove the old information
                Appointment oldAppointment = datagrid.SelectedItem as Appointment;
                appointmentList.Remove(oldAppointment);
                //add a new customer
                appointmentList.Add(newAppointment);

            }
            else { MessageBox.Show("select"); }
        }

    }

  
}

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
using System.Windows.Shapes;

namespace FinalAssignmentSDT
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window

    {

        ObservableCollection<Customer> col;

        public Window1()

        {
            InitializeComponent();
            col = new ObservableCollection<Customer>();
            col.Add(new Customer() { ID = 1, Name = "Name1", SecNumber = "mynumber1" });
            col.Add(new Customer() { ID = 2, Name = "Name2", SecNumber = "mynumber2" });
            col.Add(new Customer() { ID = 3, Name = "Name3", SecNumber = "mynumber3" });
            col.Add(new Customer() { ID = 4, Name = "Name4", SecNumber = "mynumber4" });
            datagrid.ItemsSource = col;

        }

        private void btnAdd(object sender, RoutedEventArgs e)

        {
            int id = 0;
            try
            {
                id = int.Parse(txtID.Text.Trim());
                col.Add(new Customer() { ID = id, Name = txtName.Text.Trim(), SecNumber = txtSecNumber.Text.Trim() });
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
                //remove the selectedItem from the collection source
                Customer customer = datagrid.SelectedItem as Customer;
                col.Remove(customer);
            }
        }



        private void btnUpdate(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedIndex >= 0)
            {
                // get the selected's infomation first
                Customer newCustomer = new Customer();
                newCustomer.ID = int.Parse(txtShowID.Text);
                newCustomer.Name = txtShowName.Text.Trim();
                newCustomer.SecNumber = txtShowSecNumber.Text.Trim();
                // remove the old information
                Customer customer = datagrid.SelectedItem as Customer;
                col.Remove(customer);
                //add a new customer
                col.Add(newCustomer);

            }
            else { MessageBox.Show("select"); }
        }

    }

    public class Customer

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecNumber { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
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
using _3prak.EL_PATIODataSetTableAdapters;

namespace _3prak
{
 
    public partial class Waither : Page
    {
        WAITHERTableAdapter wai = new WAITHERTableAdapter();
        public Waither()
        {
            InitializeComponent();
            WaitherDataGrid.ItemsSource = wai.GetData();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {

            string sur = surname.Text;
            string nam = name.Text;
            string mid = middlename.Text;


            wai.InsertQuery(sur, nam, mid);
            WaitherDataGrid.ItemsSource = wai.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            object id = (WaitherDataGrid.SelectedItem as DataRowView).Row[0];
            wai.DeleteQuery(Convert.ToInt32(id));
            WaitherDataGrid.ItemsSource = wai.GetData();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

            string sur = surname.Text;
            string nam = name.Text;
            string mid = middlename.Text;

            object id = (WaitherDataGrid.SelectedItem as DataRowView).Row[0];
            wai.UpdateQuery(sur, nam, mid, Convert.ToInt32(id));
            WaitherDataGrid.ItemsSource = wai.GetData();

        }
    }
}
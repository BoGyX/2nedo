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

    public partial class Visitor : Page
    {
        VISITORTableAdapter vis = new VISITORTableAdapter();
        public Visitor()
        {
            InitializeComponent();
            VisitorDataGrid.ItemsSource = vis.GetData();
        }

     
        private void Insert_Click(object sender, RoutedEventArgs e)
        {

            string sur = surname.Text;
            string nam = name.Text;
            string mid = middlename.Text;
            

            vis.InsertQuery(sur, nam, mid);
            VisitorDataGrid.ItemsSource = vis.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            object id = (VisitorDataGrid.SelectedItem as DataRowView).Row[0];
            vis.DeleteQuery(Convert.ToInt32(id));
            VisitorDataGrid.ItemsSource = vis.GetData();

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

            string sur = surname.Text;
            string nam = name.Text;
            string mid = middlename.Text;

            object id = (VisitorDataGrid.SelectedItem as DataRowView).Row[0];
            vis.UpdateQuery(sur, nam,mid, Convert.ToInt32(id));
            VisitorDataGrid.ItemsSource = vis.GetData();


        }
    }
}

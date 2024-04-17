using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
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
using System.Xml.Linq;
using _3prak.EL_PATIODataSetTableAdapters;

namespace _3prak
{

    public partial class ItalianoMenu : Page
    {
        ITALIAN_MENU_PATIOTableAdapter ital = new ITALIAN_MENU_PATIOTableAdapter();
        
        public ItalianoMenu()
        {
            InitializeComponent();
            ItalianoMenuDataGrid.ItemsSource = ital.GetData();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            string nazv = Name.Text;
            string Pric = Price.Text;
            
            ital.InsertQuery(nazv, Pric);
            ItalianoMenuDataGrid.ItemsSource = ital.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            object id = (ItalianoMenuDataGrid.SelectedItem as DataRowView).Row[0];
            ital.DeleteQuery(Convert.ToInt32(id));
            ItalianoMenuDataGrid.ItemsSource = ital.GetData();

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

            string nazv = Name.Text;
            string Pric = Price.Text;


            object id = (ItalianoMenuDataGrid.SelectedItem as DataRowView).Row[0];
            ital.UpdateQuery(nazv,Pric, Convert.ToInt32(id));
            ItalianoMenuDataGrid.ItemsSource = ital.GetData();
        }
    }
}

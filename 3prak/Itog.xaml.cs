using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
using System.Xml.Linq;
using _3prak.EL_PATIODataSetTableAdapters;
namespace _3prak
{

    public partial class Itog : Page
    {
        IL_PATIO_RESTARAUNTTableAdapter ito = new IL_PATIO_RESTARAUNTTableAdapter();
        VISITORTableAdapter vi = new VISITORTableAdapter();
        WAITHERTableAdapter wa = new WAITHERTableAdapter();
        ITALIAN_MENU_PATIOTableAdapter it = new ITALIAN_MENU_PATIOTableAdapter();
        public Itog()
        {
            InitializeComponent();
            ItogDataGrid.ItemsSource = ito.GetData();

            viComboBox.ItemsSource = vi.GetData();
            viComboBox.DisplayMemberPath = "ID_VISITOR";

            waComboBox.ItemsSource = wa.GetData();
            waComboBox.DisplayMemberPath = "ID_WAITHER";

            itComboBox.ItemsSource = it.GetData();
            itComboBox.DisplayMemberPath = "ID_ITALIAN_MENU_PATIO";



        }

       

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            


        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            object boo = (ItogDataGrid.SelectedItem as DataRowView).Row[0];
            ito.DeleteQuery(Convert.ToInt32(boo));
            ItogDataGrid.ItemsSource = ito.GetData();

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
          
        }



        private void viComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object a = (viComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(a.ToString());
        }

        private void itComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object b = (waComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(b.ToString());
        }

        private void waComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object c = (itComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(c.ToString());
        }

    }
}
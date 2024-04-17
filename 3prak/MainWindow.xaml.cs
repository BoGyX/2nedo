using _3prak.EL_PATIODataSetTableAdapters;
using System;
using System.Collections.Generic;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ItalianoMenu ItalianMenuPage = new ItalianoMenu();
            this.Content = ItalianMenuPage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Visitor VisitorPage = new Visitor();
            this.Content = VisitorPage;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Waither WaitherPage = new Waither();
            this.Content = WaitherPage;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Itog ito = new Itog();
            this.Content = ito;
        }
    }
}

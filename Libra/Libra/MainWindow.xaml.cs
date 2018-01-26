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

namespace Libra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Serial;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
            //oppapitsr
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BookData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

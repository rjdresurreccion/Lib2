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
        public int BookSerial = 0 ;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            if (BookSerial != 0)
            {

            }
            else
            {
                MessageBox.Show("No Item Selected");
            }

=======
            //oppapitsr
>>>>>>> 407694b5c1dc928ade65757e5564dbc04703c05c
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            BookSerial = Int32.Parse(txtCode.ToString());

        }

        public void BookData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dynamic SelectedRow = BookData.SelectedItem;
            if (SelectedRow != null)
            {
                BookSerial = SelectedRow.Serial;
            }
        }
    }
}

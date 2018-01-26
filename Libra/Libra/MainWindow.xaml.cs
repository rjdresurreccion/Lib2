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

namespace Libra
{   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int BookSerial = 0 ;
        DBFunctions LibQry = new DBFunctions();
        public MainWindow()
        {
            InitializeComponent();
            DataTable dt = LibQry.GetEmployeeList();

            foreach (DataRow row in dt.Rows)
            {
                _List.Add(new EmployeeModel
                {
                    Code = Int32.Parse(row["Code"].ToString()),
                    ID = (row["ID"].ToString()),
                    FullName = row["FullName"].ToString(),
                    Age = Int32.Parse(row["Age"].ToString()),
                    Division = row["Division"].ToString()
                });
            }
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
            if (BookSerial != 0)
            {

            }
            else
            {
                MessageBox.Show("No Item Selected");
            }
            
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

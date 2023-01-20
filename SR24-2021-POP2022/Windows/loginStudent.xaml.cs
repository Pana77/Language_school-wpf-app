using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SR24_2021_POP2022.Windows
{
    /// <summary>
    /// Interaction logic for loginStudent.xaml
    /// </summary>
    public partial class loginStudent : Window
    {
        public loginStudent()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source = ");
        }

        private void ButtonOdustani_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

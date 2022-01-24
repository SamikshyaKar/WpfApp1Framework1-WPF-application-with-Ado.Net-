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
using System.Windows.Shapes;

namespace WpfApp1Framework1
{
    /// <summary>
    /// Interaction logic for SecondMain.xaml
    /// </summary>
    public partial class SecondMain : Window
    {
        public SecondMain()
        {
            InitializeComponent();
        }

        private void TxtProdctID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}

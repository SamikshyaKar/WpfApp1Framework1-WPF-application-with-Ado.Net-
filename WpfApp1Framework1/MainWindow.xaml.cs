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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;


namespace WpfApp1Framework1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //String CS = "server=(local); Database=Products; Trusted_Connection=true";
        SqlConnection con = new SqlConnection("server=(local); Database=Products; Trusted_Connection=true");
        SqlCommand cmd;
        SqlDataReader rdr;
        string sql;
        private void TxtProdName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string ProdName = TxtProdName.Text;
            string ProdPrice = TxtPrice.Text;
            string ProdDiscount = TxtDiscount.Text;

            sql = "Insert into ProductTable(PName,PDiscount,PPrice) values (@ProdName,@ProdPrice,@ProdDiscount)";
            con.Open();
            cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@ProdName", ProdName);
            cmd.Parameters.AddWithValue("@ProdPrice", ProdPrice);
            cmd.Parameters.AddWithValue("@ProdDiscount", ProdDiscount);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Added");
            con.Close();

            TxtProdName.Clear();
            TxtPrice.Clear();
            TxtDiscount.Clear();
            TxtProdName.Focus();









        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string PID = TxtPID.Text;
            sql = " select * from ProductTable where PID= @PID";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@PID", PID);

            rdr = cmd.ExecuteReader();

            if(rdr.Read())
            {
                TxtProdName.Text=    rdr["PName"].ToString();
                TxtPrice.Text = rdr["PPrice"].ToString();
                TxtDiscount.Text = rdr["PDiscount"].ToString();
            }
            else
            {
                MessageBox.Show("ID not Found");
            }

            con.Close();

        }

        private void TxtPID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

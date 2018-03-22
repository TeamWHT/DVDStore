using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace ParameterizedSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GetTotalSell_Click(object sender, EventArgs e)
        {
            TotalSalesLabel.Text = string.Format("TotalSales:{0}",
                GetTotalSales(Customeridtextbox.Text));
        }
        private double GetTotalSales(string CustomerId)
        {
            double totalSales = -1;
            try
            {
                string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=LAPTOP-9N28EMML\SQLEXPRESS";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;


                command.CommandText = "GetCustomerSales";

                command.Parameters.AddWithValue("@CustomerSales", CustomerId); 



                command.Parameters.AddWithValue("@TotalSales", null);
                command.Parameters["@TotalSales"].DbType = DbType.Currency;
                command.Parameters["@TotalSales"].Direction = ParameterDirection.Output;
                connection.Open();
                command.ExecuteNonQuery();
                totalSales = Double.Parse(command.Parameters["@TotalSales"].Value.ToString());
                connection.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return totalSales;
        }
    }
}

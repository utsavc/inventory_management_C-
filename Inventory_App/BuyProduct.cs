using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_App
{
    public partial class BuyProduct : Form
    {
        private string p_Id;
        private string p_cat;

        public BuyProduct()
        {
            InitializeComponent();
        }

        public BuyProduct(string p_Id,string p_cat)
        {
            InitializeComponent();
            this.p_Id = p_Id;
            this.p_cat = p_cat;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO purchase (SalesID , ProductID , QTY, Sales_Price,Buyer , Payment_Type, Home_Delivery, Address) VALUES (@salesid, @productId, @qty, @salesPrice, @buyer ,@pay_Type, @home_Delivery, @address)";



            string connectionString = "server=131.217.174.230;user=group3;database=group3;password=glock;";
            connectionString = "server=localhost;user=root;database=group3;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@salesid", sales_Id.Text);
                command.Parameters.AddWithValue("@productId", p_Id);
                command.Parameters.AddWithValue("@qty", sales_qty.Text);
                command.Parameters.AddWithValue("@salesPrice", sales_Price.Text);
                command.Parameters.AddWithValue("@buyer", buyer.Text);
                command.Parameters.AddWithValue("@pay_Type", pay_Type.Text);
                command.Parameters.AddWithValue("@home_Delivery", home_Delivery.Text);
                command.Parameters.AddWithValue("@address", address.Text);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inserted into Database");
                }
                //Console.WriteLine("MySQL connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
           

    }
}

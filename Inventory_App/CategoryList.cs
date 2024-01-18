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
    public partial class CategoryList : Form
    {
        public CategoryList()
        {
            InitializeComponent();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            string connectionString = "server=131.217.174.230;user=group3;database=group3;password=glock;";
            connectionString = "server=localhost;user=root;database=group3;password=;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "Select Distinct Category from product";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.Write(reader.GetString(0));
                }
                Console.WriteLine("MySQL connection successful!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            new CategoryProductList(0).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new CategoryProductList(1).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            new CategoryProductList(2).Show();
        }
         
        private void button4_Click(object sender, EventArgs e)
        {

            new CategoryProductList(3).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {


            new CategoryProductList(4).Show();
        }
    }
}

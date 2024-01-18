using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventory_App
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
            loadSearchBox();
           
        }

        public void loadSearchBox()
        {
            string connectionString = "server=131.217.174.230;user=group3;database=group3;password=glock;";
            connectionString = "server=localhost;user=root;database=group3;password=;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "Select * from product";
                MySqlCommand cmd = new MySqlCommand(query,connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    searchBox.Items.Add(reader.GetString(1));
                    Console.Write(reader.GetString(1));
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

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=131.217.174.230;user=group3;database=group3;password=glock;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
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

        private void button4_Click(object sender, EventArgs e)
        {
            string searchKeyWord = searchBox.Text;

            string connectionString = "server=131.217.174.230;user=group3;database=group3;password=glock;";
            connectionString = "server=localhost;user=root;database=group3;password=;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "Select * from product where Name=@productName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@productName", searchKeyWord);
                MySqlDataReader reader = cmd.ExecuteReader();

                /*if (!reader.Read())
                {
                    MessageBox.Show("No Such Product");
                }*/

                    while (reader.Read())
                    {
                        pName.Visible = true;
                        eEfficiency.Visible = true;
                        pWidth.Visible = true;
                        pWeight.Visible = true;
                        pHeight.Visible = true;
                        pDepth.Visible = true;
                        pWarranty.Visible = true;

                        pName.Text = pName.Text + " " + reader.GetString(1);
                        eEfficiency.Text += reader.GetString(6);
                        pWidth.Text += reader.GetString(4);
                        pHeight.Text += reader.GetString(3);
                        pDepth.Text += reader.GetString("Depth");
                        pWeight.Text += reader.GetString("Weight");
                        pWarranty.Text += "";

                    }
                
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

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            new CategoryList().Show();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            new Report().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new ProductList().Show();
        }
    }
}

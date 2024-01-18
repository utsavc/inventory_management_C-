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
    public partial class CategoryProductList : Form
    {
        private int v;

        public CategoryProductList()
        {
            InitializeComponent();
        }

        public CategoryProductList(int v)
        {
            InitializeComponent();
            this.v = v;
            categoryProductListShow();
        }

        public void categoryProductListShow()
        {
            string connectionString = "server=131.217.174.230;user=group3;database=group3;password=glock;";
            connectionString = "server=localhost;user=root;database=group3;password=;";
            try {
                // Create a data adapter to retrieve data from a database
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM product where Category=@param", connectionString);
                adapter.SelectCommand.Parameters.AddWithValue("@param", v);
                // Create a datatable to hold the retrieved data
                DataTable table = new DataTable();



                // Fill the datatable with data from the database
                adapter.Fill(table);

                // Bind the datatable to the DataGridView control
                dataGridView.DataSource = table;
                 dataGridView.Columns["Column1"].DataPropertyName = "ProductId";
                dataGridView.Columns["Column2"].DataPropertyName = "Name";
                dataGridView.Columns["Column3"].DataPropertyName = "Category";
                dataGridView.Columns["Column4"].DataPropertyName = "Height";
                dataGridView.Columns["Column5"].DataPropertyName = "Width";
                dataGridView.Columns["Column6"].DataPropertyName = "Depth";
                dataGridView.Columns["Column7"].DataPropertyName = "Energy_Rating";
                dataGridView.Columns["Column8"].DataPropertyName = "base_price";
                dataGridView.Columns["Column9"].DataPropertyName = "min_Price";
                dataGridView.Columns["Column10"].DataPropertyName = "list_Price";
                dataGridView.Columns["Column11"].DataPropertyName = "Home_Delivery";
                dataGridView.Columns["Column12"].DataPropertyName = "Weight";


                 dataGridView.Columns["ProductId"].Visible = false;
                 dataGridView.Columns["Name"].Visible = false;
                 dataGridView.Columns["Category"].Visible = false;
                 dataGridView.Columns["Height"].Visible = false;
                 dataGridView.Columns["Width"].Visible = false;
                 dataGridView.Columns["Depth"].Visible = false;
                 dataGridView.Columns["Energy_Rating"].Visible = false;
                 dataGridView.Columns["base_price"].Visible = false;
                 dataGridView.Columns["min_price"].Visible = false;
                 dataGridView.Columns["list_price"].Visible = false;
                 dataGridView.Columns["Home_Delivery"].Visible = false;
                 dataGridView.Columns["Stock"].Visible = false;
                 dataGridView.Columns["Weight"].Visible = false;
                //dataGridView.DataMember = table.TableName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }

        private void CategoryProductList_Load(object sender, EventArgs e)
        {
            /*string connectionString = "server=131.217.174.230;user=group3;database=group3;password=glock;";
            connectionString = "server=localhost;user=root;database=group3;password=;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "Select Distinct Category  from product where Category=@categoryName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@categoryName", v);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.Write(reader.GetString(0));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string p_Id = product_Id.Text;
            string p_cat = hid_category.Text;
            if(p_Id==null || p_Id == "")
            {
                MessageBox.Show("Select Item from the table");
            }
            else
            {

                new BuyProduct(p_Id,p_cat).Show();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[rowIndex];
            product_Id.Text = row.Cells[0].Value.ToString();
            hid_category.Text = row.Cells[2].Value.ToString();

        }
    }
}

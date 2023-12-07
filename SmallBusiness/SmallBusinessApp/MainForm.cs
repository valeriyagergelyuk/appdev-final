using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallBusinessApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.businessDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.businessDataSet.Orders);
            // TODO: This line of code loads data into the 'businessDataSet.Products' table. You can move, or remove it, as needed.
            // this.productsTableAdapter.Fill(this.businessDataSet.Products);
            RefreshDataGridView();
        }
        private void InsertRowAndUpdateDataGridView()
        {
            string currentD = Directory.GetCurrentDirectory();


            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";

          
            string insertQuery = "INSERT INTO Products (ProductName, Description, Price,DaysBeforeShipping) VALUES (@ProductName, @Description, @Price,@DaysBeforeShipping)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ProductName", $"{productNameTextBox.Text}");
                        cmd.Parameters.AddWithValue("@Description", $"{descriptionTextBox.Text}");
                        cmd.Parameters.AddWithValue("@Price", $"{priceTextBox.Text}");
                        cmd.Parameters.AddWithValue("@DaysBeforeShipping", $"{daysTextBox.Text}");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row inserted successfully!");

                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Error inserting row.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error inserting row: Price and Shipping days must contain numeric values!");
                    }

                    
                }
            }
        }

        private void RefreshDataGridView()
        {
            
            string selectQuery = "SELECT * FROM Products";

            string currentD = Directory.GetCurrentDirectory();
           
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=SmallBusinessApp\\SmallBusinessApp\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30"; ;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                       
                        var dataTable = new System.Data.DataTable();

                        adapter.Fill(dataTable);

                        productsDataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            InsertRowAndUpdateDataGridView();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            
            string currentD = Directory.GetCurrentDirectory();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            int index = ordersDataGridView.SelectedRows[0].Index;
            string statusQuery = "Update orders set status = 1 where id = " + (index + 1);
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(statusQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {

                        var dataTable = new System.Data.DataTable();

                        adapter.Fill(dataTable);

                        ordersDataGridView.DataSource = dataTable;
                        RefreshOrdersDataGridView();
                    }
                }
            }
        }

        public void RefreshOrdersDataGridView()
        {

            string selectQuery = "SELECT * FROM Orders";

            string currentD = Directory.GetCurrentDirectory();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=SmallBusinessApp\\SmallBusinessApp\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30"; ;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {

                        var dataTable = new System.Data.DataTable();

                        adapter.Fill(dataTable);

                        ordersDataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string currentD = Directory.GetCurrentDirectory();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            int id = 0;

            try
            {
                id = Int32.Parse(idTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Enter a numeric value!");
            }
            if(id != 0)
            {
                string delquery = "delete from products where productid = " + id;

                DialogResult result = MessageBox.Show("Are you sure you want to delete the product?", "Confirm", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand cmd = new SqlCommand(delquery, connection))
                            {
                                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                {

                                    var dataTable = new System.Data.DataTable();

                                    adapter.Fill(dataTable);

                                    productsDataGridView.DataSource = dataTable;
                                    RefreshDataGridView();
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to delete the product because it is present in order.");
                    }
                }

                
            }
            
        }
    }
}

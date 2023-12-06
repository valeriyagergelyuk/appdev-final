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
    }
}

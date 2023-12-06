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
    public partial class BuyerForm : Form
    {
        public BuyerForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.businessDataSet);

        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.businessDataSet.Products);
            this.ordersTableAdapter1.Fill(this.businessDataSet.Orders);
            //RefreshOrdersDataGridView();
        }

        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            string currentD = Directory.GetCurrentDirectory();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";

            string searchQuery = "SELECT * FROM Products WHERE ProductName LIKE @ProductName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(searchQuery, connection))
                {

                    cmd.Parameters.AddWithValue("@ProductName", "%" + searchTextBox.Text + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {

                        var dataTable = new System.Data.DataTable();

                        adapter.Fill(dataTable);

                        productsDataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void viewAllProductsButton_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Products";

            string currentD = Directory.GetCurrentDirectory();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";

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

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            PlaceOrderForm placeOrderForm = new PlaceOrderForm(productsDataGridView.CurrentCell.RowIndex,this);
            placeOrderForm.ShowDialog();
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
    }
}

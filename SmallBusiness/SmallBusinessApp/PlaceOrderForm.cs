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
    public partial class PlaceOrderForm : Form
    {
        private int Row;
        private BuyerForm buyerForm;
        public PlaceOrderForm(int row, BuyerForm buyerForm)
        {
            InitializeComponent();
            Row = row;
            this.buyerForm = buyerForm;
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.businessDataSet);
            productsBindingSource.Position = Row;
        }

        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.businessDataSet.Products);

        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            DateTime todaysDate = DateTime.Today;

            int daysUntilShipping = GetDaysBeforeShipping(Convert.ToInt32(productIdTextBox.Text));

            DateTime expectedDate = todaysDate.AddDays(daysUntilShipping);

            string currentD = Directory.GetCurrentDirectory();


            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";


            string insertQuery = "INSERT INTO Orders (ProductId, Address, BuyerName,CardInfo,Price,ShippingDate,Status) VALUES (@ProductId, @Address, @BuyerName,@CardInfo,@Price,@ShippingDate,@Status)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ProductId", $"{productIdTextBox.Text}");
                        cmd.Parameters.AddWithValue("@Address", $"{addressTextBox.Text}");
                        cmd.Parameters.AddWithValue("@BuyerName", $"{nameTextBox.Text}");
                        cmd.Parameters.AddWithValue("@CardInfo", $"{cardInformationTextBox.Text}");
                        cmd.Parameters.AddWithValue("@Price", $"{priceTextBox.Text}");
                        cmd.Parameters.AddWithValue("@ShippingDate", $"{expectedDate}");
                        cmd.Parameters.AddWithValue("@Status", $"{0}");

                        buyerForm.RefreshOrdersDataGridView();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row inserted successfully!");

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


        private int GetDaysBeforeShipping(int productId)
        {
            string currentD = Directory.GetCurrentDirectory();

            int numberOfDays = 0;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + currentD + "\\BusinessDatabase.mdf;Integrated Security=True;Connect Timeout=30";


            string selectQuery = "SELECT (DaysBeforeShipping) FROM Products WHERE (ProductId) = (@ProductId) ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ProductId", $"{productId}");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                numberOfDays = Convert.ToInt32(reader["DaysBeforeShipping"]);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return numberOfDays;
            }
        }
    }
}
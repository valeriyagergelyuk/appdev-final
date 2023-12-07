using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallBusinessApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyerForm buyerForm = new BuyerForm();
            buyerForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abtLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Small Business is an application catered towards freelance artists and small business owners. When choosing to login as a " + 
                "Seller, you can post new item listings and check all the orders that have been made as well as update their status. As a Buyer, " + 
                "you can check all the items that are available in the inventoryplace an order, and check the order status.");
        }
    }
}

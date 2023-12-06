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

        }

        private void exitAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

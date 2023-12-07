namespace SmallBusinessApp
{
    partial class BuyerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.ordersTableAdapter1 = new SmallBusinessApp.BusinessDataSetTableAdapters.OrdersTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buyTabPage = new System.Windows.Forms.TabPage();
            this.viewAllProductsButton = new System.Windows.Forms.Button();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.allProductLabel = new System.Windows.Forms.Label();
            this.serachLabel = new System.Windows.Forms.Label();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessDataSet = new SmallBusinessApp.BusinessDataSet();
            this.viewOrdersTabPage = new System.Windows.Forms.TabPage();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new SmallBusinessApp.BusinessDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new SmallBusinessApp.BusinessDataSetTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.changeBtn = new System.Windows.Forms.Button();
            this.exitAppBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.legendLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.buyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataSet)).BeginInit();
            this.viewOrdersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkSalmon;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(0, 31);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(82, 13, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(904, 59);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Small Business Store";
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.buyTabPage);
            this.tabControl1.Controls.Add(this.viewOrdersTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 106);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1079, 617);
            this.tabControl1.TabIndex = 4;
            // 
            // buyTabPage
            // 
            this.buyTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buyTabPage.Controls.Add(this.viewAllProductsButton);
            this.buyTabPage.Controls.Add(this.addToCartBtn);
            this.buyTabPage.Controls.Add(this.searchButton);
            this.buyTabPage.Controls.Add(this.searchTextBox);
            this.buyTabPage.Controls.Add(this.allProductLabel);
            this.buyTabPage.Controls.Add(this.serachLabel);
            this.buyTabPage.Controls.Add(this.productsDataGridView);
            this.buyTabPage.Location = new System.Drawing.Point(4, 26);
            this.buyTabPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buyTabPage.Name = "buyTabPage";
            this.buyTabPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buyTabPage.Size = new System.Drawing.Size(1071, 587);
            this.buyTabPage.TabIndex = 0;
            this.buyTabPage.Text = "Buy Product";
            // 
            // viewAllProductsButton
            // 
            this.viewAllProductsButton.BackColor = System.Drawing.Color.IndianRed;
            this.viewAllProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllProductsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewAllProductsButton.Location = new System.Drawing.Point(861, 64);
            this.viewAllProductsButton.Name = "viewAllProductsButton";
            this.viewAllProductsButton.Size = new System.Drawing.Size(185, 23);
            this.viewAllProductsButton.TabIndex = 6;
            this.viewAllProductsButton.Text = "View All Products";
            this.viewAllProductsButton.UseVisualStyleBackColor = false;
            this.viewAllProductsButton.Click += new System.EventHandler(this.viewAllProductsButton_Click);
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToCartBtn.Location = new System.Drawing.Point(458, 499);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(148, 46);
            this.addToCartBtn.TabIndex = 5;
            this.addToCartBtn.Text = "Add to Cart";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.IndianRed;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(952, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(637, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(309, 22);
            this.searchTextBox.TabIndex = 3;
            // 
            // allProductLabel
            // 
            this.allProductLabel.AutoSize = true;
            this.allProductLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProductLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allProductLabel.Location = new System.Drawing.Point(9, 6);
            this.allProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allProductLabel.Name = "allProductLabel";
            this.allProductLabel.Size = new System.Drawing.Size(98, 24);
            this.allProductLabel.TabIndex = 1;
            this.allProductLabel.Text = "Products";
            // 
            // serachLabel
            // 
            this.serachLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serachLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serachLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serachLabel.Location = new System.Drawing.Point(-1, 0);
            this.serachLabel.Name = "serachLabel";
            this.serachLabel.Size = new System.Drawing.Size(1064, 41);
            this.serachLabel.TabIndex = 2;
            this.serachLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(8, 106);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 62;
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.Size = new System.Drawing.Size(1056, 369);
            this.productsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 350;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DaysBeforeShipping";
            this.dataGridViewTextBoxColumn5.HeaderText = "DaysBeforeShipping";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 180;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.businessDataSet;
            // 
            // businessDataSet
            // 
            this.businessDataSet.DataSetName = "BusinessDataSet";
            this.businessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewOrdersTabPage
            // 
            this.viewOrdersTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewOrdersTabPage.Controls.Add(this.legendLabel);
            this.viewOrdersTabPage.Controls.Add(this.refreshBtn);
            this.viewOrdersTabPage.Controls.Add(this.ordersDataGridView);
            this.viewOrdersTabPage.Location = new System.Drawing.Point(4, 26);
            this.viewOrdersTabPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewOrdersTabPage.Name = "viewOrdersTabPage";
            this.viewOrdersTabPage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewOrdersTabPage.Size = new System.Drawing.Size(1071, 587);
            this.viewOrdersTabPage.TabIndex = 1;
            this.viewOrdersTabPage.Text = "View Orders";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 62;
            this.ordersDataGridView.RowTemplate.Height = 28;
            this.ordersDataGridView.Size = new System.Drawing.Size(1060, 534);
            this.ordersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn8.HeaderText = "Address";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 170;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BuyerName";
            this.dataGridViewTextBoxColumn9.HeaderText = "BuyerName";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CardInfo";
            this.dataGridViewTextBoxColumn10.HeaderText = "CardInfo";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn11.HeaderText = "Price";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 110;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ShippingDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "ShippingDate";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.businessDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter1;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = SmallBusinessApp.BusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(1079, 31);
            this.productsBindingNavigator.TabIndex = 5;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(40, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.IndianRed;
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeBtn.Location = new System.Drawing.Point(886, 31);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(193, 59);
            this.changeBtn.TabIndex = 6;
            this.changeBtn.Text = "Change Users";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // exitAppBtn
            // 
            this.exitAppBtn.BackColor = System.Drawing.Color.Salmon;
            this.exitAppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitAppBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAppBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitAppBtn.Location = new System.Drawing.Point(771, 31);
            this.exitAppBtn.Name = "exitAppBtn";
            this.exitAppBtn.Size = new System.Drawing.Size(119, 59);
            this.exitAppBtn.TabIndex = 7;
            this.exitAppBtn.Text = "Exit app";
            this.exitAppBtn.UseVisualStyleBackColor = false;
            this.exitAppBtn.Click += new System.EventHandler(this.exitAppBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.IndianRed;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshBtn.Location = new System.Drawing.Point(945, 543);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(118, 36);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // legendLabel
            // 
            this.legendLabel.AutoSize = true;
            this.legendLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.legendLabel.Location = new System.Drawing.Point(467, 553);
            this.legendLabel.Name = "legendLabel";
            this.legendLabel.Size = new System.Drawing.Size(472, 17);
            this.legendLabel.TabIndex = 2;
            this.legendLabel.Text = "Status will be checked when the item is marked as shipped by the seller.";
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1079, 723);
            this.Controls.Add(this.exitAppBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.productsBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BuyerForm";
            this.Text = "BuyerForm";
            this.Load += new System.EventHandler(this.BuyerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.buyTabPage.ResumeLayout(false);
            this.buyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessDataSet)).EndInit();
            this.viewOrdersTabPage.ResumeLayout(false);
            this.viewOrdersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private BusinessDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage buyTabPage;
        private System.Windows.Forms.TabPage viewOrdersTabPage;
        private BusinessDataSet businessDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private BusinessDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private BusinessDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Label allProductLabel;
        private System.Windows.Forms.Label serachLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button exitAppBtn;
        private System.Windows.Forms.Button viewAllProductsButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label legendLabel;
    }
}
namespace SmallBusiness
{
    partial class MainForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.allItemsPage = new System.Windows.Forms.TabPage();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.homePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.IndianRed;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(1341, -2);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(310, 89);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Change users";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkSalmon;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(-3, -2);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(105, 15, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(1350, 89);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Small Business";
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchLabel.Location = new System.Drawing.Point(-6, 0);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.searchLabel.Size = new System.Drawing.Size(1642, 56);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search items";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(1048, 14);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(373, 28);
            this.searchBox.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Salmon;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(1210, -2);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(136, 89);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit App";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.homePage);
            this.tabControl.Controls.Add(this.allItemsPage);
            this.tabControl.Controls.Add(this.profilePage);
            this.tabControl.Controls.Add(this.ordersPage);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-6, 97);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1642, 869);
            this.tabControl.TabIndex = 5;
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homePage.Controls.Add(this.searchBox);
            this.homePage.Controls.Add(this.searchLabel);
            this.homePage.Location = new System.Drawing.Point(4, 30);
            this.homePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homePage.Size = new System.Drawing.Size(1634, 835);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home";
            // 
            // allItemsPage
            // 
            this.allItemsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allItemsPage.Location = new System.Drawing.Point(4, 30);
            this.allItemsPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allItemsPage.Name = "allItemsPage";
            this.allItemsPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allItemsPage.Size = new System.Drawing.Size(1634, 835);
            this.allItemsPage.TabIndex = 1;
            this.allItemsPage.Text = "All items";
            // 
            // profilePage
            // 
            this.profilePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profilePage.Location = new System.Drawing.Point(4, 30);
            this.profilePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilePage.Name = "profilePage";
            this.profilePage.Size = new System.Drawing.Size(1634, 835);
            this.profilePage.TabIndex = 2;
            this.profilePage.Text = "Profile";
            // 
            // ordersPage
            // 
            this.ordersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ordersPage.Location = new System.Drawing.Point(4, 30);
            this.ordersPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Size = new System.Drawing.Size(1634, 835);
            this.ordersPage.TabIndex = 3;
            this.ordersPage.Text = "Order Statuses";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1636, 960);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.loginBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Small Business";
            this.tabControl.ResumeLayout(false);
            this.homePage.ResumeLayout(false);
            this.homePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage homePage;
        private System.Windows.Forms.TabPage allItemsPage;
        private System.Windows.Forms.TabPage profilePage;
        private System.Windows.Forms.TabPage ordersPage;
    }
}


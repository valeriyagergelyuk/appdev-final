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
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.itemsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.IndianRed;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Bodoni MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(894, -1);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(207, 64);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login / Create Account";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkSalmon;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(135, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(70, 10, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(763, 58);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Small Business";
            // 
            // searchLabel
            // 
            this.searchLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchLabel.Location = new System.Drawing.Point(133, 57);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.searchLabel.Size = new System.Drawing.Size(958, 37);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search users or items";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(635, 67);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(250, 21);
            this.searchBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.itemsBtn);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 626);
            this.panel1.TabIndex = 4;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.IndianRed;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeBtn.Location = new System.Drawing.Point(0, 3);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(141, 75);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // itemsBtn
            // 
            this.itemsBtn.BackColor = System.Drawing.Color.IndianRed;
            this.itemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemsBtn.Location = new System.Drawing.Point(0, 84);
            this.itemsBtn.Name = "itemsBtn";
            this.itemsBtn.Size = new System.Drawing.Size(141, 75);
            this.itemsBtn.TabIndex = 5;
            this.itemsBtn.Text = "All items";
            this.itemsBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1091, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.loginBtn);
            this.Name = "MainForm";
            this.Text = "Small Business";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button itemsBtn;
        private System.Windows.Forms.Button button1;
    }
}


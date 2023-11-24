namespace SmallBusiness
{
    partial class CreateAccountForm
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
            this.signUpLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox2 = new System.Windows.Forms.TextBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpLabel
            // 
            this.signUpLabel.BackColor = System.Drawing.Color.DarkSalmon;
            this.signUpLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpLabel.Location = new System.Drawing.Point(-2, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(335, 49);
            this.signUpLabel.TabIndex = 0;
            this.signUpLabel.Text = "Sign up";
            this.signUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(50, 75);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(234, 23);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Text = "Email";
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(50, 115);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(234, 23);
            this.userTextBox.TabIndex = 2;
            this.userTextBox.Text = "Username";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(50, 157);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(234, 23);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.Tag = "";
            this.passTextBox.Text = "Password";
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // passTextBox2
            // 
            this.passTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox2.Location = new System.Drawing.Point(50, 198);
            this.passTextBox2.Name = "passTextBox2";
            this.passTextBox2.Size = new System.Drawing.Size(234, 23);
            this.passTextBox2.TabIndex = 4;
            this.passTextBox2.Tag = "";
            this.passTextBox2.Text = "Confirm Password";
            this.passTextBox2.UseSystemPasswordChar = true;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.IndianRed;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpBtn.Location = new System.Drawing.Point(109, 238);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(114, 33);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginLabel.Location = new System.Drawing.Point(141, 288);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(47, 17);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Log in";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(333, 314);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.passTextBox2);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.signUpLabel);
            this.Name = "CreateAccountForm";
            this.Text = "Create an Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox passTextBox2;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label loginLabel;
    }
}
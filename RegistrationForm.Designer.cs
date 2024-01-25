namespace QBankingSystem
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labUsername = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labConfirmPassword = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.textPESEL = new System.Windows.Forms.TextBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Location = new System.Drawing.Point(563, 20);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(75, 20);
            this.labUsername.TabIndex = 0;
            this.labUsername.Text = "Username";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(349, 254);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(70, 20);
            this.labPassword.TabIndex = 1;
            this.labPassword.Text = "Password";
            // 
            // labConfirmPassword
            // 
            this.labConfirmPassword.AutoSize = true;
            this.labConfirmPassword.Location = new System.Drawing.Point(322, 322);
            this.labConfirmPassword.Name = "labConfirmPassword";
            this.labConfirmPassword.Size = new System.Drawing.Size(127, 20);
            this.labConfirmPassword.TabIndex = 2;
            this.labConfirmPassword.Text = "Confirm Password";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(569, 84);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(46, 20);
            this.labEmail.TabIndex = 3;
            this.labEmail.Text = "Email";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(452, 43);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(301, 27);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(238, 277);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(301, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(238, 345);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(301, 27);
            this.txtConfirmPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(452, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(301, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(238, 403);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(301, 29);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(129, 20);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(49, 20);
            this.labName.TabIndex = 9;
            this.labName.Text = "Name";
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.Location = new System.Drawing.Point(126, 84);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(67, 20);
            this.labSurname.TabIndex = 10;
            this.labSurname.Text = "Surname";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(129, 151);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(50, 20);
            this.labPhone.TabIndex = 11;
            this.labPhone.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 27);
            this.txtName.TabIndex = 12;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(12, 107);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(301, 27);
            this.txtSurname.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 174);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(301, 27);
            this.txtPhone.TabIndex = 14;
            // 
            // txtPesel
            // 
            this.textPESEL.Location = new System.Drawing.Point(452, 174);
            this.textPESEL.Name = "txtPesel";
            this.textPESEL.Size = new System.Drawing.Size(301, 27);
            this.textPESEL.TabIndex = 16;
            // 
            // labPesel
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(569, 151);
            this.labelPESEL.Name = "labPesel";
            this.labelPESEL.Size = new System.Drawing.Size(42, 20);
            this.labelPESEL.TabIndex = 15;
            this.labelPESEL.Text = "Pesel";
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.textPESEL);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labConfirmPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labUsername);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labConfirmPassword;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox textPESEL;
        private System.Windows.Forms.Label labelPESEL;
    }
}


namespace QBankingSystem
{
    partial class UserAccountForm
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
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labPESEL;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.ComboBox cmbAccountType;

        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labPESEL = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(50, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(123, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name: FirstName";
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.Location = new System.Drawing.Point(50, 100);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(140, 20);
            this.labSurname.TabIndex = 1;
            this.labSurname.Text = "Surname: LastName";
            // 
            // labPESEL
            // 
            this.labPESEL.AutoSize = true;
            this.labPESEL.Location = new System.Drawing.Point(50, 150);
            this.labPESEL.Name = "labPESEL";
            this.labPESEL.Size = new System.Drawing.Size(143, 20);
            this.labPESEL.TabIndex = 2;
            this.labPESEL.Text = "PESEL: 12345678901";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(413, 220);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(150, 30);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 20;
            this.lstAccounts.Location = new System.Drawing.Point(221, 50);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(357, 164);
            this.lstAccounts.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(248, 221);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 29);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Personal Account",
            "Savings Account",
            "Checking Account",
            "Business Account",
            "Currency Account"});
            this.cmbAccountType.Location = new System.Drawing.Point(413, 256);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(150, 28);
            this.cmbAccountType.TabIndex = 6;
            this.cmbAccountType.Text = "Personal Account";
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 312);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.labPESEL);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.cmbAccountType);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserAccountForm";
            this.Text = "Account Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnRefresh;
    }
    #endregion
}
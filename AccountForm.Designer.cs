﻿namespace QBankingSystem
{
    partial class AccountForm
    {

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labPESEL;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.ListBox lstAccounts;

        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labPESEL = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lstAccounts = new System.Windows.Forms.ListBox();
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
            this.btnCreateAccount.Location = new System.Drawing.Point(50, 200);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(150, 30);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "Create Account";
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 20;
            this.lstAccounts.Location = new System.Drawing.Point(239, 66);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(200, 164);
            this.lstAccounts.TabIndex = 4;
            // this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.lstAccounts_SelectedIndexChanged);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 312);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.labPESEL);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.labName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountForm";
            this.Text = "Account Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

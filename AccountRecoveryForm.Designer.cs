namespace QBankingSystem
{
    partial class AccountRecoveryForm
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
            this.labUsernamePhoneEmail = new System.Windows.Forms.Label();
            this.txtUsernamePhoneEmail = new System.Windows.Forms.TextBox();
            this.btnRecover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labUsernamePhoneEmail
            // 
            this.labUsernamePhoneEmail.AutoSize = true;
            this.labUsernamePhoneEmail.Location = new System.Drawing.Point(100, 100);
            this.labUsernamePhoneEmail.Name = "labUsernamePhoneEmail";
            this.labUsernamePhoneEmail.Size = new System.Drawing.Size(226, 20);
            this.labUsernamePhoneEmail.TabIndex = 0;
            this.labUsernamePhoneEmail.Text = "Enter Username, Phone, or Email:";
            // 
            // txtUsernamePhoneEmail
            // 
            this.txtUsernamePhoneEmail.Location = new System.Drawing.Point(100, 130);
            this.txtUsernamePhoneEmail.Name = "txtUsernamePhoneEmail";
            this.txtUsernamePhoneEmail.Size = new System.Drawing.Size(300, 27);
            this.txtUsernamePhoneEmail.TabIndex = 1;
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(100, 170);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(100, 30);
            this.btnRecover.TabIndex = 2;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // AccountRecoveryForm
            // 
            this.AcceptButton = this.btnRecover;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 300);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.txtUsernamePhoneEmail);
            this.Controls.Add(this.labUsernamePhoneEmail);
            this.Name = "AccountRecoveryForm";
            this.Text = "Account Recovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUsernamePhoneEmail;
        private System.Windows.Forms.TextBox txtUsernamePhoneEmail;
        private System.Windows.Forms.Button btnRecover;
    }
}

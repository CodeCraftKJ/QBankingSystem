namespace QBankingSystem.Forms
{
    partial class BaseAccountForm
    {
        private System.Windows.Forms.Label accountInfoLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawalButton;

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
            this.accountInfoLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountInfoLabel
            // 
            this.accountInfoLabel.AutoSize = true;
            this.accountInfoLabel.Location = new System.Drawing.Point(30, 20);
            this.accountInfoLabel.Name = "accountInfoLabel";
            this.accountInfoLabel.Size = new System.Drawing.Size(93, 20);
            this.accountInfoLabel.TabIndex = 0;
            this.accountInfoLabel.Text = "Account Info";
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.AutoSize = true;
            this.accountBalanceLabel.Location = new System.Drawing.Point(30, 50);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(161, 20);
            this.accountBalanceLabel.TabIndex = 1;
            this.accountBalanceLabel.Text = "Account Balance: $0.00";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(34, 100);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 27);
            this.amountTextBox.TabIndex = 2;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(150, 100);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(80, 30);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawalButton
            // 
            this.withdrawalButton.Location = new System.Drawing.Point(250, 100);
            this.withdrawalButton.Name = "withdrawalButton";
            this.withdrawalButton.Size = new System.Drawing.Size(100, 30);
            this.withdrawalButton.TabIndex = 4;
            this.withdrawalButton.Text = "Withdraw";
            this.withdrawalButton.UseVisualStyleBackColor = true;
            // 
            // BaseAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.withdrawalButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.accountBalanceLabel);
            this.Controls.Add(this.accountInfoLabel);
            this.Name = "BaseAccountForm";
            this.Text = "BaseAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

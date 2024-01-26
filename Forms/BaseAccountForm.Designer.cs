namespace QBankingSystem.Forms
{
    partial class BaseAccountForm
    {
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label accountBalanceLabel;
        private System.Windows.Forms.Button makeTransferButton;

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
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.accountBalanceLabel = new System.Windows.Forms.Label();
            this.makeTransferButton = new System.Windows.Forms.Button();
            this.GTHbutton = new System.Windows.Forms.Button();
            this.loadTransferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(3, 40);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(121, 20);
            this.accountNumberLabel.TabIndex = 0;
            this.accountNumberLabel.Text = "Account Number";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Location = new System.Drawing.Point(3, 7);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(98, 20);
            this.accountTypeLabel.TabIndex = 1;
            this.accountTypeLabel.Text = "Account Type";
            // 
            // accountBalanceLabel
            // 
            this.accountBalanceLabel.AutoSize = true;
            this.accountBalanceLabel.Location = new System.Drawing.Point(3, 71);
            this.accountBalanceLabel.Name = "accountBalanceLabel";
            this.accountBalanceLabel.Size = new System.Drawing.Size(161, 20);
            this.accountBalanceLabel.TabIndex = 2;
            this.accountBalanceLabel.Text = "Account Balance: $0.00";
            // 
            // makeTransferButton
            // 
            this.makeTransferButton.Location = new System.Drawing.Point(3, 94);
            this.makeTransferButton.Name = "makeTransferButton";
            this.makeTransferButton.Size = new System.Drawing.Size(150, 30);
            this.makeTransferButton.TabIndex = 3;
            this.makeTransferButton.Text = "Make Transfer";
            this.makeTransferButton.UseVisualStyleBackColor = true;
            this.makeTransferButton.Click += new System.EventHandler(this.makeTransferButton_Click_1);
            // 
            // GTHbutton
            // 
            this.GTHbutton.Location = new System.Drawing.Point(4, 165);
            this.GTHbutton.Name = "GTHbutton";
            this.GTHbutton.Size = new System.Drawing.Size(170, 93);
            this.GTHbutton.TabIndex = 4;
            this.GTHbutton.Text = "Generate Transactions history csv";
            this.GTHbutton.UseVisualStyleBackColor = true;
            this.GTHbutton.Click += new System.EventHandler(this.GTHbutton_Click);
            // 
            // loadTransferButton
            // 
            this.loadTransferButton.Location = new System.Drawing.Point(3, 130);
            this.loadTransferButton.Name = "loadTransferButton";
            this.loadTransferButton.Size = new System.Drawing.Size(149, 29);
            this.loadTransferButton.TabIndex = 5;
            this.loadTransferButton.Text = "Load Transfer csv";
            this.loadTransferButton.UseVisualStyleBackColor = true;
            this.loadTransferButton.Click += new System.EventHandler(this.loadTransferButton_Click);
            // 
            // BaseAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 262);
            this.Controls.Add(this.loadTransferButton);
            this.Controls.Add(this.GTHbutton);
            this.Controls.Add(this.accountBalanceLabel);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.makeTransferButton);
            this.Name = "BaseAccountForm";
            this.Text = "BaseAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GTHbutton;
        private System.Windows.Forms.Button loadTransferButton;
    }
}

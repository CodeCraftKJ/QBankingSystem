namespace QBankingSystem.Forms
{
    partial class LoanForm
    {
        private System.Windows.Forms.Label loanAmountLabel;
        private System.Windows.Forms.Label loanTermLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label proposedInterestLabel;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.TextBox loanTermTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Button takeLoanButton;

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
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.loanTermLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.proposedInterestLabel = new System.Windows.Forms.Label();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.loanTermTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.takeLoanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.Location = new System.Drawing.Point(11, 15);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(101, 20);
            this.loanAmountLabel.TabIndex = 0;
            this.loanAmountLabel.Text = "Loan Amount:";
            // 
            // loanTermLabel
            // 
            this.loanTermLabel.AutoSize = true;
            this.loanTermLabel.Location = new System.Drawing.Point(11, 52);
            this.loanTermLabel.Name = "loanTermLabel";
            this.loanTermLabel.Size = new System.Drawing.Size(81, 20);
            this.loanTermLabel.TabIndex = 1;
            this.loanTermLabel.Text = "Loan Term:";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(11, 89);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(95, 20);
            this.interestRateLabel.TabIndex = 2;
            this.interestRateLabel.Text = "Interest Rate:";
            // 
            // proposedInterestLabel
            // 
            this.proposedInterestLabel.AutoSize = true;
            this.proposedInterestLabel.Location = new System.Drawing.Point(11, 126);
            this.proposedInterestLabel.Name = "proposedInterestLabel";
            this.proposedInterestLabel.Size = new System.Drawing.Size(128, 20);
            this.proposedInterestLabel.TabIndex = 3;
            this.proposedInterestLabel.Text = "Proposed Interest:";
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(164, 12);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(89, 27);
            this.loanAmountTextBox.TabIndex = 4;
            // 
            // loanTermTextBox
            // 
            this.loanTermTextBox.Location = new System.Drawing.Point(164, 49);
            this.loanTermTextBox.Name = "loanTermTextBox";
            this.loanTermTextBox.Size = new System.Drawing.Size(89, 27);
            this.loanTermTextBox.TabIndex = 5;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(164, 86);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(89, 27);
            this.interestRateTextBox.TabIndex = 6;
            // 
            // takeLoanButton
            // 
            this.takeLoanButton.Location = new System.Drawing.Point(82, 170);
            this.takeLoanButton.Name = "takeLoanButton";
            this.takeLoanButton.Size = new System.Drawing.Size(120, 35);
            this.takeLoanButton.TabIndex = 8;
            this.takeLoanButton.Text = "Take Loan";
            this.takeLoanButton.UseVisualStyleBackColor = true;
            this.takeLoanButton.Click += new System.EventHandler(this.takeLoanButton_Click);
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 224);
            this.Controls.Add(this.takeLoanButton);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.loanTermTextBox);
            this.Controls.Add(this.loanAmountTextBox);
            this.Controls.Add(this.proposedInterestLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.loanTermLabel);
            this.Controls.Add(this.loanAmountLabel);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

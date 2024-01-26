namespace QBankingSystem.Forms
{
    partial class TransferForm
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
            this.peselLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.sourceAccountLabel = new System.Windows.Forms.Label();
            this.targetAccountLabel = new System.Windows.Forms.Label();
            this.transferTitleLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.sourceAccountTextBox = new System.Windows.Forms.TextBox();
            this.targetAccountTextBox = new System.Windows.Forms.TextBox();
            this.transferTitleTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.confirmTransferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peselLabel
            // 
            this.peselLabel.AutoSize = true;
            this.peselLabel.Location = new System.Drawing.Point(12, 9);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(48, 20);
            this.peselLabel.TabIndex = 0;
            this.peselLabel.Text = "PESEL";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 45);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 81);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 117);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // sourceAccountLabel
            // 
            this.sourceAccountLabel.AutoSize = true;
            this.sourceAccountLabel.Location = new System.Drawing.Point(12, 153);
            this.sourceAccountLabel.Name = "sourceAccountLabel";
            this.sourceAccountLabel.Size = new System.Drawing.Size(112, 20);
            this.sourceAccountLabel.TabIndex = 4;
            this.sourceAccountLabel.Text = "Source Account";
            // 
            // targetAccountLabel
            // 
            this.targetAccountLabel.AutoSize = true;
            this.targetAccountLabel.Location = new System.Drawing.Point(12, 189);
            this.targetAccountLabel.Name = "targetAccountLabel";
            this.targetAccountLabel.Size = new System.Drawing.Size(108, 20);
            this.targetAccountLabel.TabIndex = 5;
            this.targetAccountLabel.Text = "Target Account";
            // 
            // transferTitleLabel
            // 
            this.transferTitleLabel.AutoSize = true;
            this.transferTitleLabel.Location = new System.Drawing.Point(12, 225);
            this.transferTitleLabel.Name = "transferTitleLabel";
            this.transferTitleLabel.Size = new System.Drawing.Size(94, 20);
            this.transferTitleLabel.TabIndex = 6;
            this.transferTitleLabel.Text = "Transfer Title";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(12, 261);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(62, 20);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Amount";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(152, 6);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.ReadOnly = true;
            this.peselTextBox.Size = new System.Drawing.Size(200, 27);
            this.peselTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(152, 42);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 27);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(152, 78);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 27);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(152, 114);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(200, 27);
            this.usernameTextBox.TabIndex = 11;
            // 
            // sourceAccountTextBox
            // 
            this.sourceAccountTextBox.Location = new System.Drawing.Point(152, 150);
            this.sourceAccountTextBox.Name = "sourceAccountTextBox";
            this.sourceAccountTextBox.Size = new System.Drawing.Size(200, 27);
            this.sourceAccountTextBox.TabIndex = 12;
            // 
            // targetAccountTextBox
            // 
            this.targetAccountTextBox.Location = new System.Drawing.Point(152, 186);
            this.targetAccountTextBox.Name = "targetAccountTextBox";
            this.targetAccountTextBox.Size = new System.Drawing.Size(200, 27);
            this.targetAccountTextBox.TabIndex = 13;
            // 
            // transferTitleTextBox
            // 
            this.transferTitleTextBox.Location = new System.Drawing.Point(152, 222);
            this.transferTitleTextBox.Name = "transferTitleTextBox";
            this.transferTitleTextBox.Size = new System.Drawing.Size(200, 27);
            this.transferTitleTextBox.TabIndex = 14;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(152, 258);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 27);
            this.amountTextBox.TabIndex = 15;
            // 
            // confirmTransferButton
            // 
            this.confirmTransferButton.Location = new System.Drawing.Point(152, 301);
            this.confirmTransferButton.Name = "confirmTransferButton";
            this.confirmTransferButton.Size = new System.Drawing.Size(200, 35);
            this.confirmTransferButton.TabIndex = 16;
            this.confirmTransferButton.Text = "Confirm Transfer";
            this.confirmTransferButton.UseVisualStyleBackColor = true;
            this.confirmTransferButton.Click += new System.EventHandler(this.confirmTransferButton_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 350);
            this.Controls.Add(this.confirmTransferButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.transferTitleTextBox);
            this.Controls.Add(this.targetAccountTextBox);
            this.Controls.Add(this.sourceAccountTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.transferTitleLabel);
            this.Controls.Add(this.targetAccountLabel);
            this.Controls.Add(this.sourceAccountLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.peselLabel);
            this.Name = "TransferForm";
            this.Text = "Make Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label sourceAccountLabel;
        private System.Windows.Forms.Label targetAccountLabel;
        private System.Windows.Forms.Label transferTitleLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox sourceAccountTextBox;
        private System.Windows.Forms.TextBox targetAccountTextBox;
        private System.Windows.Forms.TextBox transferTitleTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button confirmTransferButton;
    }
}

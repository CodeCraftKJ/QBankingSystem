using System;
using System.Windows.Forms;

namespace QBankingSystem
{
    public partial class AccountForm : Form
    {
        private Label labAccountInfo;
        private Label labAccountBalance;
        private Button btnRefresh;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnTransfer;

        public AccountForm()
        {
            InitializeComponent();
        }

        // The InitializeComponent method is where you design the form visually.
        // You can create controls, set their properties, and add event handlers here.
        private void InitializeComponent()
        {
            this.labAccountInfo = new System.Windows.Forms.Label();
            this.labAccountBalance = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Set the size of the form
            this.ClientSize = new System.Drawing.Size(400, 250);

            // 
            // labAccountInfo
            // 
            this.labAccountInfo.AutoSize = true;
            this.labAccountInfo.Location = new System.Drawing.Point(50, 50);
            this.labAccountInfo.Name = "labAccountInfo";
            this.labAccountInfo.Size = new System.Drawing.Size(200, 20);
            this.labAccountInfo.TabIndex = 0;
            this.labAccountInfo.Text = "Account Information: User123";

            // 
            // labAccountBalance
            // 
            this.labAccountBalance.AutoSize = true;
            this.labAccountBalance.Location = new System.Drawing.Point(50, 100);
            this.labAccountBalance.Name = "labAccountBalance";
            this.labAccountBalance.Size = new System.Drawing.Size(150, 20);
            this.labAccountBalance.TabIndex = 1;
            this.labAccountBalance.Text = "Account Balance: $1000.00";

            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(50, 150);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(180, 150);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 30);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);

            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(50, 200);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 30);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);

            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(180, 200);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(100, 30);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);

            // 
            // AccountForm
            // 
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labAccountBalance);
            this.Controls.Add(this.labAccountInfo);
            this.Name = "AccountForm";
            this.Text = "Account Overview";
            this.ResumeLayout(false);
        }

        // Event handler for the Refresh button click
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Implement logic to refresh account data and update labels
            // For now, let's assume we retrieve and display updated account data
            UpdateAccountInfo("User123", 1500.00);
        }

        // Event handler for the Deposit button click
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // TODO: Implement logic to open a deposit form
            MessageBox.Show("Opening Deposit Form...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for the Withdraw button click
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // TODO: Implement logic to open a withdraw form
            MessageBox.Show("Opening Withdraw Form...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler for the Transfer button click
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // TODO: Implement logic to open a transfer form
            MessageBox.Show("Opening Transfer Form...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to update account information labels
        private void UpdateAccountInfo(string username, double balance)
        {
            labAccountInfo.Text = "Account Information: " + username;
            labAccountBalance.Text = "Account Balance: $" + balance.ToString("F2");
        }
    }
}

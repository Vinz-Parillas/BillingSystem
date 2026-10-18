namespace BillingSystem
{
    partial class frmAnalytics
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
            lblTitle = new Label();
            lblTotalUnpaid = new Label();
            lblTotalRevenue = new Label();
            lblTotalCustomers = new Label();
            plotMonthlyRevenue = new ScottPlot.WinForms.FormsPlot();
            plotPaidUnpaid = new ScottPlot.WinForms.FormsPlot();
            lblTop5Title = new Label();
            dgvTop5 = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            TotalConsumption = new DataGridViewTextBoxColumn();
            TotalBilled = new DataGridViewTextBoxColumn();
            btnCloseAnalytics = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(-8, 9);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1000, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Analytics Dashboard";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // lblTotalUnpaid
            // 
            lblTotalUnpaid.AutoSize = true;
            lblTotalUnpaid.Location = new Point(690, 65);
            lblTotalUnpaid.Name = "lblTotalUnpaid";
            lblTotalUnpaid.Size = new Size(111, 15);
            lblTotalUnpaid.TabIndex = 1;
            lblTotalUnpaid.Text = "Total Unpaid:  ₱0.00";
            lblTotalUnpaid.Click += lblTotalUnpaid_Click;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(435, 65);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(118, 15);
            lblTotalRevenue.TabIndex = 2;
            lblTotalRevenue.Text = "Total Revenue:  ₱0.00";
            lblTotalRevenue.Click += lblTotalRevenue_Click;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Location = new Point(175, 65);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(105, 15);
            lblTotalCustomers.TabIndex = 3;
            lblTotalCustomers.Text = "Total Customers: 0";
            lblTotalCustomers.Click += lblTotalCustomers_Click;
            // 
            // plotMonthlyRevenue
            // 
            plotMonthlyRevenue.Location = new Point(45, 113);
            plotMonthlyRevenue.Name = "plotMonthlyRevenue";
            plotMonthlyRevenue.Size = new Size(450, 220);
            plotMonthlyRevenue.TabIndex = 4;
            plotMonthlyRevenue.Load += formsPlot1_Load;
            // 
            // plotPaidUnpaid
            // 
            plotPaidUnpaid.Location = new Point(491, 113);
            plotPaidUnpaid.Name = "plotPaidUnpaid";
            plotPaidUnpaid.Size = new Size(450, 220);
            plotPaidUnpaid.TabIndex = 5;
            // 
            // lblTop5Title
            // 
            lblTop5Title.AutoSize = true;
            lblTop5Title.Location = new Point(82, 353);
            lblTop5Title.Name = "lblTop5Title";
            lblTop5Title.Size = new Size(188, 15);
            lblTop5Title.TabIndex = 6;
            lblTop5Title.Text = "Top 5 Customers by Consumption";
            lblTop5Title.Click += lblTop5Title_Click;
            // 
            // dgvTop5
            // 
            dgvTop5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5.Columns.AddRange(new DataGridViewColumn[] { FullName, TotalConsumption, TotalBilled });
            dgvTop5.Location = new Point(82, 386);
            dgvTop5.Name = "dgvTop5";
            dgvTop5.Size = new Size(847, 150);
            dgvTop5.TabIndex = 7;
            // 
            // FullName
            // 
            FullName.HeaderText = "Column1";
            FullName.Name = "FullName";
            // 
            // TotalConsumption
            // 
            TotalConsumption.HeaderText = "Column1";
            TotalConsumption.Name = "TotalConsumption";
            // 
            // TotalBilled
            // 
            TotalBilled.HeaderText = "Column1";
            TotalBilled.Name = "TotalBilled";
            // 
            // btnCloseAnalytics
            // 
            btnCloseAnalytics.Location = new Point(854, 560);
            btnCloseAnalytics.Name = "btnCloseAnalytics";
            btnCloseAnalytics.Size = new Size(75, 23);
            btnCloseAnalytics.TabIndex = 8;
            btnCloseAnalytics.Text = "Close";
            btnCloseAnalytics.UseVisualStyleBackColor = true;
            btnCloseAnalytics.Click += btnCloseAnalytics_Click;
            // 
            // frmAnalytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnCloseAnalytics);
            Controls.Add(dgvTop5);
            Controls.Add(lblTop5Title);
            Controls.Add(plotPaidUnpaid);
            Controls.Add(plotMonthlyRevenue);
            Controls.Add(lblTotalCustomers);
            Controls.Add(lblTotalRevenue);
            Controls.Add(lblTotalUnpaid);
            Controls.Add(lblTitle);
            Name = "frmAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Analytics Dashboard";
            Load += frmAnalytics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTotalUnpaid;
        private Label lblTotalRevenue;
        private Label lblTotalCustomers;
        private ScottPlot.WinForms.FormsPlot plotMonthlyRevenue;
        private ScottPlot.WinForms.FormsPlot plotPaidUnpaid;
        private Label lblTop5Title;
        private DataGridView dgvTop5;
        private Button btnCloseAnalytics;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn TotalConsumption;
        private DataGridViewTextBoxColumn TotalBilled;
    }
}
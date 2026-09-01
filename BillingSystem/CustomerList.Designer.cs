namespace BillingSystem
{
    partial class CustomerList
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
            dgvCustomers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btbDelete = new Button();
            btnLogout = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(69, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer List";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvCustomers.Location = new Point(69, 96);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(735, 417);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "CustomerID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FullName";
            Column2.HeaderText = "Full Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Adress";
            Column3.HeaderText = "Adress";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ContactNumber";
            Column4.HeaderText = "Contact No.";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Email";
            Column5.HeaderText = "Email";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Balance";
            Column6.HeaderText = "Balance";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Location = new Point(378, 535);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 33);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btbDelete
            // 
            btbDelete.Location = new Point(79, 535);
            btbDelete.Margin = new Padding(3, 4, 3, 4);
            btbDelete.Name = "btbDelete";
            btbDelete.Size = new Size(86, 31);
            btbDelete.TabIndex = 3;
            btbDelete.Text = "Delete";
            btbDelete.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(706, 537);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(587, 41);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(689, 39);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 6;
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 615);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnLogout);
            Controls.Add(btbDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Customer List (Flores)";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btbDelete;
        private Button btnLogout;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
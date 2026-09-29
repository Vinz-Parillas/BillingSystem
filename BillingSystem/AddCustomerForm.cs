using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;

namespace BillingSystem
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show(
                    "Full Name is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show(
                    "Address is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show(
                    "Contact Number is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtContact.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Email is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return false;
            }

            if (!decimal.TryParse(txtBalance.Text, out _))
            {
                MessageBox.Show(
                    "Initial Balance must be a valid number (e.g. 0.00).",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBalance.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Customers
                                     (FullName, Address, ContactNumber, Email, Balance, Status)
                                     VALUES
                                     (@FullName, @Address, @ContactNumber, @Email, @Balance, @Status)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@FullName",
                            txtFullName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Address",
                            txtAddress.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@ContactNumber",
                            txtContact.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Email",
                            txtEmail.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Balance",
                            decimal.Parse(txtBalance.Text));

                        cmd.Parameters.AddWithValue(
                            "@Status",
                            "Active");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Customer saved successfully.",
                                "Saved",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving customer: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtBalance.Text = "0.00";
            txtFullName.Focus();
        }

        // Existing Designer events
        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblContact_Click(object sender, EventArgs e)
        {
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
        }
    }
}
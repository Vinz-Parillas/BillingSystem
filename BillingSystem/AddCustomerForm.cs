using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BillingSystem
{
    public partial class AddCustomerForm : Form
    {
        private int _editCustomerId = 0;

        public AddCustomerForm()
        {
            InitializeComponent();
            _editCustomerId = 0;
        }

        public AddCustomerForm(int customerId)
        {
            InitializeComponent();
            _editCustomerId = customerId;
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            if (_editCustomerId > 0)
            {
                lblTitle.Text = "Edit Customer";
                this.Text = "Billing System - Edit Customer";
                LoadCustomerData(_editCustomerId);
            }
            else
            {
                lblTitle.Text = "Add New Customer";
                txtBalance.Text = "0.00";
            }
        }

        private void LoadCustomerData(int customerId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT FullName, Address, ContactNumber, Email, Balance FROM Customers WHERE CustomerID = @CustomerID;";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFullName.Text = reader.GetString("FullName");
                                txtAddress.Text = reader.GetString("Address");
                                txtContact.Text = reader.GetString("ContactNumber");
                                txtEmail.Text = reader.GetString("Email");
                                txtBalance.Text = reader.GetDecimal("Balance").ToString("N2");
                            }
                            else
                            {
                                MessageBox.Show("Customer record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblContact_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Step 1: Validate input before touching the database
            if (!ValidateInputs()) return;

            if (_editCustomerId == 0)
            {
                InsertCustomer(); // ADD mode from Activity 3
            }
            else
            {
                UpdateCustomer(); // EDIT mode new in Activity 4
            }
        }

        private void InsertCustomer()
        {
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
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        decimal balance = 0;
                        decimal.TryParse(txtBalance.Text, out balance);
                        cmd.Parameters.AddWithValue("@Balance", balance);
                        cmd.Parameters.AddWithValue("@Status", "Active");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCustomer()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized UPDATE only the row matching
                    // @CustomerID is changed
                    string sql = @"UPDATE Customers
                                   SET FullName = @FullName,
                                       Address = @Address,
                                       ContactNumber = @ContactNumber,
                                       Email = @Email,
                                       Balance = @Balance
                                   WHERE CustomerID = @CustomerID;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Balance", decimal.Parse(txtBalance.Text));
                        cmd.Parameters.AddWithValue("@CustomerID", _editCustomerId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Close the form CustomerListForm will refresh on close
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. The record may no longer exist.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    internal static class DatabaseConnection
    {
        public static MySqlConnection GetConnection()
        {
            var connStr = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(connStr))
            {
                // Added Allow PublicKey Retrieval=True and SslMode=None
                connStr = "Server=localhost;Database=billingdb;Uid=root;Pwd=12345;";
            }
            return new MySqlConnection(connStr);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSupportAgent
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
        }

        private void txtConfirmPasswred_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnable_Click(object sender, EventArgs e)
        {

        }

        private void txtNewpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            
                string currentPassword = txtCurrentPassword.Text.Trim();
                string newPassword = txtNewPassword.Text.Trim();
                string confirmPassword = txtConfirmPassword.Text.Trim();

                // Validate that all fields are filled
                if (string.IsNullOrWhiteSpace(currentPassword) ||
                    string.IsNullOrWhiteSpace(newPassword) ||
                    string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate that new password and confirm password match
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // For demo: Check current password is correct (this should be verified against stored password)
                if (currentPassword != "Sushmitha") // Replace with actual password check
                {
                    MessageBox.Show("Current Password is incorrect.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // If validation passes
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Here you can add logic to update the password in your database or settings
        }

        private void btnEnable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsave5_Click(object sender, EventArgs e)
        {
            if (radioEnable.Checked)
            {
                MessageBox.Show("Two-Factor Authentication Enabled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioDisable.Checked)
            {
                MessageBox.Show("Two-Factor Authentication Disabled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select Enable or Disable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


    



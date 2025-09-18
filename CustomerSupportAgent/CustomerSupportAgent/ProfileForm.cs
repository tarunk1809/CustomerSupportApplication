using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSupportAgent
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        private void btnUpdate_Click(object sender, EventArgs e)
        {



            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Check for empty fields or placeholders
            if (name == "Enter your name" || string.IsNullOrWhiteSpace(name) ||
                email == "Enter your email" || string.IsNullOrWhiteSpace(email) ||
                phone == "Enter phone number" || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill all details.");
                return;
            }

            // Name validation
            foreach (char c in name)
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Please enter a valid name (letters only).");
                    txtName.Focus();
                    return;
                }

            // Email validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email.");
                txtEmail.Focus();
                return;
            }

            // Phone validation
            if (phone.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 digits.");
                txtPhone.Focus();
                return;
            }

            // All valid
            MessageBox.Show("Profile updated successfully ✅");
        }
        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                // Use System.Net.Mail for robust email validation
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }











    }
}








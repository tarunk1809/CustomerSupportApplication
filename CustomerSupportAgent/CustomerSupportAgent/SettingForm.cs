using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSupportAgent
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void lblsetting_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
                // Clear previous content
                panelPage.Controls.Clear();

                // Create instance of Profile form
                ProfileForm profilePage = new ProfileForm();
                profilePage.TopLevel = false; // Make it a child form
                profilePage.FormBorderStyle = FormBorderStyle.None; // Remove border
                profilePage.Dock = DockStyle.Fill; // Fill the panel

                // Add to panel and show
                panelPage.Controls.Add(profilePage);
                profilePage.Show();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            // Clear existing controls from panelMain
            panelPage.Controls.Clear();

            // Create a new instance of the Security form
            SecurityForm securityPage = new SecurityForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Add the form to the panel and show it
            panelPage.Controls.Add(securityPage);
            securityPage.Show();
        }


       
            private void btnNotification_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the panel
            panelPage.Controls.Clear();

            // Create a new instance of NotificationForm
            NotificationForm notificationPage = new NotificationForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // Add the form to the panel and display it
            panelPage.Controls.Add(notificationPage);
            notificationPage.Show();
        }

        

       
          /*  private void btnApperence_Click(object sender, EventArgs e)
        {
            // Clear previous content
            panelPage.Controls.Clear();

            // Create instance of Appearance form
            ApperenceForm appearancePage = new ApperenceForm();
            appearancePage.TopLevel = false; // Make it a child form
            appearancePage.FormBorderStyle = FormBorderStyle.None; // Remove border
            appearancePage.Dock = DockStyle.Fill; // Fill the panel

            // Add to panel and show
            panelPage.Controls.Add(appearancePage);
            appearancePage.Show();
        }*/

        
        
     

        private void btnappearance_Click_1(object sender, EventArgs e)
        {
            // Clear previous content
            panelPage.Controls.Clear();

            // Create instance of Appearance form
            AppearanceForm appearancePage = new AppearanceForm();
            appearancePage.TopLevel = false; // Make it a child form
            appearancePage.FormBorderStyle = FormBorderStyle.None; // Remove border
            appearancePage.Dock = DockStyle.Fill; // Fill the panel

            // Add to panel and show
            panelPage.Controls.Add(appearancePage);
            appearancePage.Show();
        }

        
    }
}


    



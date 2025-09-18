using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CustomerSupportAgent
{
    public partial class AppearanceForm : Form
    {
        // Add this field to the AppearanceForm class (at the top, after the class declaration)
        private Timer timerClock;
        // Replace the field declaration for dtpDate
        private DateTimePicker dtpDate;

        // In the constructor, after InitializeComponent(), initialize dtpDate if not already done
        public AppearanceForm()
        {
            InitializeComponent();
            // Assuming dtpDate is a DateTimePicker control on the form
            dtpDate = this.Controls.OfType<DateTimePicker>().FirstOrDefault();
        }

        private void btnsave3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("✅ Saved Successfully!", "Success",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        

        //$"Time: {time}";

        //MessageBox.Show(message, "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make sure items are added AFTER InitializeComponent()
            cmbTheme.Items.Clear();  // optional, clear existing items
            cmbTheme.Items.Add("Light");
            cmbTheme.Items.Add("Dark");
            cmbTheme.SelectedIndex = 0; // default Light

            cmbTheme.SelectedIndexChanged += cmbTheme_SelectedIndexChanged;

        }

        private void AppearanceForm_Load(object sender, EventArgs e)
        {
           // === THEME COMBOBOX ===
            cmbTheme.Items.Clear();
            cmbTheme.Items.Add("Light");
            cmbTheme.Items.Add("Dark");
            cmbTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTheme.SelectedIndex = 0; // Default Light
            cmbTheme.SelectedIndexChanged += CmbTheme_SelectedIndexChanged;

            // === FONT COMBOBOX ===
            cmbFont.Items.Clear();
            cmbFont.Items.Add("Arial");
            cmbFont.Items.Add("Times New Roman");
            cmbFont.Items.Add("Calibri");
            cmbFont.Items.Add("Verdana");
            cmbFont.Items.Add("Segoe UI");
            cmbFont.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFont.SelectedIndex = 0;

         
            
        }// Default Arial
        // Add this method to match the event handler assignment for cmbFont.SelectedIndexChanged
        private void CmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = cmbFont.SelectedItem.ToString();
            Font newFont = new Font(selectedFont, 10);

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = newFont;
            }
        }
        

        

        // === THEME CHANGE HANDLER ===
        private void CmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTheme.SelectedItem.ToString() == "Dark")
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.White;
                    ctrl.BackColor = Color.Black;
                }
            }
            else // Light Theme
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.Black;
                    ctrl.BackColor = Color.White;
                }
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string selectedFont = cmbFont.SelectedItem.ToString();
                Font newFont = new Font(selectedFont, 10);

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Font = newFont;
                }
            }
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
    
}

      

    




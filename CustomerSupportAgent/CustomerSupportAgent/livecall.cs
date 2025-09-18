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
    public partial class livecall : Form
    {
        public livecall()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void LiveCallDashboard_Load(object sender, EventArgs e)
        {
            // Create DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Call ID");
            dt.Columns.Add("Caller Name");
            dt.Columns.Add("Agent");
            dt.Columns.Add("Start Time");
            dt.Columns.Add("End Time");
            dt.Columns.Add("Duration");
            dt.Columns.Add("Status");

            // Dummy Data (Only Agent 1)
            dt.Rows.Add("C001", "John Doe", "Agent 1", "09:00 AM", "09:05 AM", "05:00", "Answered");
            dt.Rows.Add("C002", "Alice Brown", "Agent 1", "09:10 AM", "09:20 AM", "10:00", "Answered");
            dt.Rows.Add("C003", "Michael Smith", "Agent 1", "09:25 AM", "-", "-", "Missed");
            dt.Rows.Add("C004", "Sophia Lee", "Agent 1", "09:30 AM", "09:42 AM", "12:00", "Answered");
            dt.Rows.Add("C005", "James Wilson", "Agent 1", "09:45 AM", "09:55 AM", "10:00", "Answered");
            dt.Rows.Add("C006", "David Johnson", "Agent 1", "10:00 AM", "-", "03:15", "Ongoing");
            dt.Rows.Add("C007", "Emma Davis", "Agent 1", "10:10 AM", "10:16 AM", "06:00", "Answered");
            dt.Rows.Add("C008", "Chris Miller", "Agent 1", "10:20 AM", "10:25 AM", "05:00", "Answered");
            dt.Rows.Add("C009", "Olivia Taylor", "Agent 1", "10:30 AM", "-", "-", "Missed");
            dt.Rows.Add("C010", "Liam Martinez", "Agent 1", "10:35 AM", "10:47 AM", "12:00", "Answered");

            // Bind Data (No need to filter since only Agent 1 is added)
            calltable.DataSource = dt;

            // Auto resize
            calltable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            label5.Text = "Agent1";
            label6.Text = "Agent@mail.com";
        }

    }

}



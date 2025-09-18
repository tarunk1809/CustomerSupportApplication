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
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxticket_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            string message = "Settings saved with:\n\n";

            message += chkIncomingCall.Checked ? "✔ Incoming Call Enabled\n" : "✘ Incoming Call Disabled\n";
            message += chkNewChat.Checked ? "✔ New Chat Enabled\n" : "✘ New Chat Disabled\n";
            message += chkNewTicket.Checked ? "✔ New Ticket Enabled\n" : "✘ New Ticket Disabled\n";
            message += chkNotificationSound.Checked ? "✔ Notification Sound On" : "✘ Notification Sound Off";

            MessageBox.Show(message, "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
    }
}

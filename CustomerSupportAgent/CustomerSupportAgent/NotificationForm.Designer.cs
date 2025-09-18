namespace CustomerSupportAgent
{
    partial class NotificationForm
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
            this.chkIncomingCall = new System.Windows.Forms.CheckBox();
            this.chkNewChat = new System.Windows.Forms.CheckBox();
            this.chkNewTicket = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkNotificationSound = new System.Windows.Forms.CheckBox();
            this.lblNotificationss = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkIncomingCall
            // 
            this.chkIncomingCall.AutoSize = true;
            this.chkIncomingCall.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncomingCall.Location = new System.Drawing.Point(24, 86);
            this.chkIncomingCall.Name = "chkIncomingCall";
            this.chkIncomingCall.Size = new System.Drawing.Size(126, 24);
            this.chkIncomingCall.TabIndex = 4;
            this.chkIncomingCall.Text = "Incoming Call";
            this.chkIncomingCall.UseVisualStyleBackColor = true;
            // 
            // chkNewChat
            // 
            this.chkNewChat.AutoSize = true;
            this.chkNewChat.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewChat.Location = new System.Drawing.Point(24, 138);
            this.chkNewChat.Name = "chkNewChat";
            this.chkNewChat.Size = new System.Drawing.Size(98, 24);
            this.chkNewChat.TabIndex = 5;
            this.chkNewChat.Text = "New Chat";
            this.chkNewChat.UseVisualStyleBackColor = true;
            // 
            // chkNewTicket
            // 
            this.chkNewTicket.AutoSize = true;
            this.chkNewTicket.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewTicket.Location = new System.Drawing.Point(24, 190);
            this.chkNewTicket.Name = "chkNewTicket";
            this.chkNewTicket.Size = new System.Drawing.Size(109, 24);
            this.chkNewTicket.TabIndex = 6;
            this.chkNewTicket.Text = "New Ticket";
            this.chkNewTicket.UseVisualStyleBackColor = true;
            this.chkNewTicket.CheckedChanged += new System.EventHandler(this.checkBoxticket_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // btnsave2
            // 
            this.btnsave2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave2.Location = new System.Drawing.Point(114, 302);
            this.btnsave2.Name = "btnsave2";
            this.btnsave2.Size = new System.Drawing.Size(75, 34);
            this.btnsave2.TabIndex = 11;
            this.btnsave2.Text = "Save";
            this.btnsave2.UseVisualStyleBackColor = true;
            this.btnsave2.Click += new System.EventHandler(this.btnsave2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNotificationss);
            this.panel1.Controls.Add(this.btnsave2);
            this.panel1.Controls.Add(this.chkNotificationSound);
            this.panel1.Controls.Add(this.chkNewTicket);
            this.panel1.Controls.Add(this.chkIncomingCall);
            this.panel1.Controls.Add(this.chkNewChat);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 493);
            this.panel1.TabIndex = 12;
            // 
            // chkNotificationSound
            // 
            this.chkNotificationSound.AutoSize = true;
            this.chkNotificationSound.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotificationSound.Location = new System.Drawing.Point(24, 242);
            this.chkNotificationSound.Name = "chkNotificationSound";
            this.chkNotificationSound.Size = new System.Drawing.Size(165, 24);
            this.chkNotificationSound.TabIndex = 0;
            this.chkNotificationSound.Text = "Notification Sound";
            this.chkNotificationSound.UseVisualStyleBackColor = true;
            // 
            // lblNotificationss
            // 
            this.lblNotificationss.AutoSize = true;
            this.lblNotificationss.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationss.Location = new System.Drawing.Point(20, 25);
            this.lblNotificationss.Name = "lblNotificationss";
            this.lblNotificationss.Size = new System.Drawing.Size(106, 19);
            this.lblNotificationss.TabIndex = 12;
            this.lblNotificationss.Text = "Notifications";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "NotificationForm";
            this.Text = "NotificationForn";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIncomingCall;
        private System.Windows.Forms.CheckBox chkNewChat;
        private System.Windows.Forms.CheckBox chkNewTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkNotificationSound;
        private System.Windows.Forms.Label lblNotificationss;
    }
}
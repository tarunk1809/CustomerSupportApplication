namespace CustomerSupportAgent
{
    partial class SecurityForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.radioEnable = new System.Windows.Forms.RadioButton();
            this.radioDisable = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsave5 = new System.Windows.Forms.Button();
            this.lblConfirmpassword = new System.Windows.Forms.Label();
            this.lblNewpassword = new System.Windows.Forms.Label();
            this.lblCurrentpassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblSecurity1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Change Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(231, 167);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(180, 22);
            this.txtNewPassword.TabIndex = 22;
            this.txtNewPassword.Tag = "*";
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewpassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(231, 212);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(180, 22);
            this.txtConfirmPassword.TabIndex = 23;
            this.txtConfirmPassword.Tag = "*";
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPasswred_TextChanged);
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuth.Location = new System.Drawing.Point(51, 313);
            this.lblAuth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(228, 22);
            this.lblAuth.TabIndex = 24;
            this.lblAuth.Text = "Two-Factor Authentication";
            // 
            // radioEnable
            // 
            this.radioEnable.AutoSize = true;
            this.radioEnable.Location = new System.Drawing.Point(55, 356);
            this.radioEnable.Name = "radioEnable";
            this.radioEnable.Size = new System.Drawing.Size(68, 20);
            this.radioEnable.TabIndex = 26;
            this.radioEnable.TabStop = true;
            this.radioEnable.Text = "Enable";
            this.radioEnable.UseVisualStyleBackColor = true;
            this.radioEnable.CheckedChanged += new System.EventHandler(this.btnEnable_CheckedChanged);
            // 
            // radioDisable
            // 
            this.radioDisable.AutoSize = true;
            this.radioDisable.Location = new System.Drawing.Point(55, 393);
            this.radioDisable.Name = "radioDisable";
            this.radioDisable.Size = new System.Drawing.Size(72, 20);
            this.radioDisable.TabIndex = 27;
            this.radioDisable.TabStop = true;
            this.radioDisable.Text = "Disable";
            this.radioDisable.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(79, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSecurity1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnsave5);
            this.panel1.Controls.Add(this.lblConfirmpassword);
            this.panel1.Controls.Add(this.lblNewpassword);
            this.panel1.Controls.Add(this.lblCurrentpassword);
            this.panel1.Controls.Add(this.txtCurrentPassword);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.lblAuth);
            this.panel1.Controls.Add(this.radioEnable);
            this.panel1.Controls.Add(this.radioDisable);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 491);
            this.panel1.TabIndex = 29;
            // 
            // btnsave5
            // 
            this.btnsave5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave5.Location = new System.Drawing.Point(79, 446);
            this.btnsave5.Name = "btnsave5";
            this.btnsave5.Size = new System.Drawing.Size(75, 32);
            this.btnsave5.TabIndex = 33;
            this.btnsave5.Text = "Save";
            this.btnsave5.UseVisualStyleBackColor = true;
            this.btnsave5.Click += new System.EventHandler(this.btnsave5_Click);
            // 
            // lblConfirmpassword
            // 
            this.lblConfirmpassword.AutoSize = true;
            this.lblConfirmpassword.Location = new System.Drawing.Point(52, 218);
            this.lblConfirmpassword.Name = "lblConfirmpassword";
            this.lblConfirmpassword.Size = new System.Drawing.Size(115, 16);
            this.lblConfirmpassword.TabIndex = 32;
            this.lblConfirmpassword.Text = "Confirm Password";
            // 
            // lblNewpassword
            // 
            this.lblNewpassword.AutoSize = true;
            this.lblNewpassword.Location = new System.Drawing.Point(55, 173);
            this.lblNewpassword.Name = "lblNewpassword";
            this.lblNewpassword.Size = new System.Drawing.Size(97, 16);
            this.lblNewpassword.TabIndex = 31;
            this.lblNewpassword.Text = "New Password";
            // 
            // lblCurrentpassword
            // 
            this.lblCurrentpassword.AutoSize = true;
            this.lblCurrentpassword.Location = new System.Drawing.Point(52, 128);
            this.lblCurrentpassword.Name = "lblCurrentpassword";
            this.lblCurrentpassword.Size = new System.Drawing.Size(112, 16);
            this.lblCurrentpassword.TabIndex = 30;
            this.lblCurrentpassword.Text = "Current Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(231, 122);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(180, 22);
            this.txtCurrentPassword.TabIndex = 29;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // lblSecurity1
            // 
            this.lblSecurity1.AutoSize = true;
            this.lblSecurity1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurity1.Location = new System.Drawing.Point(54, 29);
            this.lblSecurity1.Name = "lblSecurity1";
            this.lblSecurity1.Size = new System.Drawing.Size(75, 22);
            this.lblSecurity1.TabIndex = 34;
            this.lblSecurity1.Text = "Security";
            // 
            // SecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 491);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SecurityForm";
            this.Text = "SecurityForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.RadioButton radioEnable;
        private System.Windows.Forms.RadioButton radioDisable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConfirmpassword;
        private System.Windows.Forms.Label lblNewpassword;
        private System.Windows.Forms.Label lblCurrentpassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Button btnsave5;
        private System.Windows.Forms.Label lblSecurity1;
    }
}
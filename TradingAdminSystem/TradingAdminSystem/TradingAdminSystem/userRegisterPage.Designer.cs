namespace WindowsFormsApplication1
{
    partial class userRegisterPage
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
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DOBTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.selectRoleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(119, 28);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last name";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(119, 85);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First name";
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(119, 111);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(119, 57);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 8;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(119, 137);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // DOBTextbox
            // 
            this.DOBTextbox.Location = new System.Drawing.Point(119, 163);
            this.DOBTextbox.Name = "DOBTextbox";
            this.DOBTextbox.Size = new System.Drawing.Size(100, 20);
            this.DOBTextbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of birth";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(119, 231);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Role";
            // 
            // selectRoleComboBox
            // 
            this.selectRoleComboBox.FormattingEnabled = true;
            this.selectRoleComboBox.Items.AddRange(new object[] {
            "Shareholder",
            "Broker",
            "Stock Exchange Manager"});
            this.selectRoleComboBox.Location = new System.Drawing.Point(119, 193);
            this.selectRoleComboBox.Name = "selectRoleComboBox";
            this.selectRoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectRoleComboBox.TabIndex = 18;
            this.selectRoleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userRegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.selectRoleComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.DOBTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextbox);
            this.Name = "userRegisterPage";
            this.Text = "User Register Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DOBTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectRoleComboBox;
    }
}
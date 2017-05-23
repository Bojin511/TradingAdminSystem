namespace WindowsFormsApplication1
{
    partial class adminSystemMain
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
            this.viewStatsTab = new System.Windows.Forms.TabPage();
            this.viewChartButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contactUserTab = new System.Windows.Forms.TabPage();
            this.banUserTab = new System.Windows.Forms.TabPage();
            this.banUserbutton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.banUserTextBox = new System.Windows.Forms.TextBox();
            this.updateDetailsTab = new System.Windows.Forms.TabPage();
            this.selectRoleComboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.updateUserDetailButton = new System.Windows.Forms.Button();
            this.DOBTextbox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.emailTextbox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.passwordTextbox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lastNameTextbox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.firstNameTextbox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.usernameTextbox3 = new System.Windows.Forms.TextBox();
            this.viewIssuesTab = new System.Windows.Forms.TabPage();
            this.completeRadioButton = new System.Windows.Forms.RadioButton();
            this.inProgressRadioButton = new System.Windows.Forms.RadioButton();
            this.OutstandingRadioButton = new System.Windows.Forms.RadioButton();
            this.viewIssuesDataGridView = new System.Windows.Forms.DataGridView();
            this.viewIssuesButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.viewUsersTab = new System.Windows.Forms.TabPage();
            this.viewUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.viewUsersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addDeleteUserTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectRoleComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.DOBTextbox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.usernameTextbox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.changePermissionTab = new System.Windows.Forms.TabPage();
            this.selectRoleComboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.changePermissionButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.usernameTextbox2 = new System.Windows.Forms.TextBox();
            this.logoffTab = new System.Windows.Forms.TabPage();
            this.logoffButton = new System.Windows.Forms.Button();
            this.viewStatsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.banUserTab.SuspendLayout();
            this.updateDetailsTab.SuspendLayout();
            this.viewIssuesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewIssuesDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.viewUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersDataGridView)).BeginInit();
            this.addDeleteUserTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.changePermissionTab.SuspendLayout();
            this.logoffTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewStatsTab
            // 
            this.viewStatsTab.Controls.Add(this.viewChartButton);
            this.viewStatsTab.Controls.Add(this.chart1);
            this.viewStatsTab.Location = new System.Drawing.Point(4, 22);
            this.viewStatsTab.Name = "viewStatsTab";
            this.viewStatsTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewStatsTab.Size = new System.Drawing.Size(713, 543);
            this.viewStatsTab.TabIndex = 7;
            this.viewStatsTab.Text = "View Statistics";
            this.viewStatsTab.UseVisualStyleBackColor = true;
            // 
            // viewChartButton
            // 
            this.viewChartButton.Location = new System.Drawing.Point(8, 83);
            this.viewChartButton.Name = "viewChartButton";
            this.viewChartButton.Size = new System.Drawing.Size(79, 23);
            this.viewChartButton.TabIndex = 1;
            this.viewChartButton.Text = "Get Statistics";
            this.viewChartButton.UseVisualStyleBackColor = true;
            this.viewChartButton.Click += new System.EventHandler(this.viewChartButton_Click);
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(93, 23);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(614, 514);
            this.chart1.TabIndex = 0;
            // 
            // contactUserTab
            // 
            this.contactUserTab.Location = new System.Drawing.Point(4, 22);
            this.contactUserTab.Name = "contactUserTab";
            this.contactUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.contactUserTab.Size = new System.Drawing.Size(713, 543);
            this.contactUserTab.TabIndex = 6;
            this.contactUserTab.Text = "Contact User";
            this.contactUserTab.UseVisualStyleBackColor = true;
            // 
            // banUserTab
            // 
            this.banUserTab.Controls.Add(this.banUserbutton);
            this.banUserTab.Controls.Add(this.label18);
            this.banUserTab.Controls.Add(this.banUserTextBox);
            this.banUserTab.Location = new System.Drawing.Point(4, 22);
            this.banUserTab.Name = "banUserTab";
            this.banUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.banUserTab.Size = new System.Drawing.Size(713, 543);
            this.banUserTab.TabIndex = 5;
            this.banUserTab.Text = "Ban User";
            this.banUserTab.UseVisualStyleBackColor = true;
            // 
            // banUserbutton
            // 
            this.banUserbutton.Location = new System.Drawing.Point(80, 96);
            this.banUserbutton.Name = "banUserbutton";
            this.banUserbutton.Size = new System.Drawing.Size(75, 23);
            this.banUserbutton.TabIndex = 46;
            this.banUserbutton.Text = "Ban User";
            this.banUserbutton.UseVisualStyleBackColor = true;
            this.banUserbutton.Click += new System.EventHandler(this.banUserbutton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Username";
            // 
            // banUserTextBox
            // 
            this.banUserTextBox.Location = new System.Drawing.Point(80, 32);
            this.banUserTextBox.Name = "banUserTextBox";
            this.banUserTextBox.Size = new System.Drawing.Size(100, 20);
            this.banUserTextBox.TabIndex = 44;
            this.banUserTextBox.TextChanged += new System.EventHandler(this.banUserTextBox_TextChanged);
            // 
            // updateDetailsTab
            // 
            this.updateDetailsTab.Controls.Add(this.selectRoleComboBox2);
            this.updateDetailsTab.Controls.Add(this.label10);
            this.updateDetailsTab.Controls.Add(this.updateUserDetailButton);
            this.updateDetailsTab.Controls.Add(this.DOBTextbox3);
            this.updateDetailsTab.Controls.Add(this.label11);
            this.updateDetailsTab.Controls.Add(this.emailTextbox3);
            this.updateDetailsTab.Controls.Add(this.label13);
            this.updateDetailsTab.Controls.Add(this.label14);
            this.updateDetailsTab.Controls.Add(this.passwordTextbox3);
            this.updateDetailsTab.Controls.Add(this.label15);
            this.updateDetailsTab.Controls.Add(this.lastNameTextbox3);
            this.updateDetailsTab.Controls.Add(this.label16);
            this.updateDetailsTab.Controls.Add(this.firstNameTextbox3);
            this.updateDetailsTab.Controls.Add(this.label17);
            this.updateDetailsTab.Controls.Add(this.usernameTextbox3);
            this.updateDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.updateDetailsTab.Name = "updateDetailsTab";
            this.updateDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateDetailsTab.Size = new System.Drawing.Size(713, 543);
            this.updateDetailsTab.TabIndex = 4;
            this.updateDetailsTab.Text = "Update Details";
            this.updateDetailsTab.UseVisualStyleBackColor = true;
            // 
            // selectRoleComboBox2
            // 
            this.selectRoleComboBox2.FormattingEnabled = true;
            this.selectRoleComboBox2.Items.AddRange(new object[] {
            "System Administrator",
            "Shareholder",
            "Broker",
            "Stock Exchange Manager"});
            this.selectRoleComboBox2.Location = new System.Drawing.Point(98, 200);
            this.selectRoleComboBox2.Name = "selectRoleComboBox2";
            this.selectRoleComboBox2.Size = new System.Drawing.Size(121, 21);
            this.selectRoleComboBox2.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Role";
            // 
            // updateUserDetailButton
            // 
            this.updateUserDetailButton.Location = new System.Drawing.Point(98, 236);
            this.updateUserDetailButton.Name = "updateUserDetailButton";
            this.updateUserDetailButton.Size = new System.Drawing.Size(112, 23);
            this.updateUserDetailButton.TabIndex = 44;
            this.updateUserDetailButton.Text = "Update User Detail";
            this.updateUserDetailButton.UseVisualStyleBackColor = true;
            this.updateUserDetailButton.Click += new System.EventHandler(this.updateUserDetailButton_Click);
            // 
            // DOBTextbox3
            // 
            this.DOBTextbox3.Location = new System.Drawing.Point(98, 170);
            this.DOBTextbox3.Name = "DOBTextbox3";
            this.DOBTextbox3.Size = new System.Drawing.Size(100, 20);
            this.DOBTextbox3.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Date of birth";
            // 
            // emailTextbox3
            // 
            this.emailTextbox3.Location = new System.Drawing.Point(98, 144);
            this.emailTextbox3.Name = "emailTextbox3";
            this.emailTextbox3.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox3.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Password";
            // 
            // passwordTextbox3
            // 
            this.passwordTextbox3.Location = new System.Drawing.Point(98, 64);
            this.passwordTextbox3.Name = "passwordTextbox3";
            this.passwordTextbox3.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox3.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "First name";
            // 
            // lastNameTextbox3
            // 
            this.lastNameTextbox3.Location = new System.Drawing.Point(98, 118);
            this.lastNameTextbox3.Name = "lastNameTextbox3";
            this.lastNameTextbox3.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextbox3.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Last name";
            // 
            // firstNameTextbox3
            // 
            this.firstNameTextbox3.Location = new System.Drawing.Point(98, 92);
            this.firstNameTextbox3.Name = "firstNameTextbox3";
            this.firstNameTextbox3.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextbox3.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Username";
            // 
            // usernameTextbox3
            // 
            this.usernameTextbox3.Location = new System.Drawing.Point(98, 35);
            this.usernameTextbox3.Name = "usernameTextbox3";
            this.usernameTextbox3.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox3.TabIndex = 32;
            // 
            // viewIssuesTab
            // 
            this.viewIssuesTab.Controls.Add(this.completeRadioButton);
            this.viewIssuesTab.Controls.Add(this.inProgressRadioButton);
            this.viewIssuesTab.Controls.Add(this.OutstandingRadioButton);
            this.viewIssuesTab.Controls.Add(this.viewIssuesDataGridView);
            this.viewIssuesTab.Controls.Add(this.viewIssuesButton);
            this.viewIssuesTab.Location = new System.Drawing.Point(4, 22);
            this.viewIssuesTab.Name = "viewIssuesTab";
            this.viewIssuesTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewIssuesTab.Size = new System.Drawing.Size(713, 543);
            this.viewIssuesTab.TabIndex = 3;
            this.viewIssuesTab.Text = "View Issues";
            this.viewIssuesTab.UseVisualStyleBackColor = true;
            // 
            // completeRadioButton
            // 
            this.completeRadioButton.AutoSize = true;
            this.completeRadioButton.Location = new System.Drawing.Point(47, 435);
            this.completeRadioButton.Name = "completeRadioButton";
            this.completeRadioButton.Size = new System.Drawing.Size(123, 17);
            this.completeRadioButton.TabIndex = 5;
            this.completeRadioButton.TabStop = true;
            this.completeRadioButton.Text = "Completed Requests";
            this.completeRadioButton.UseVisualStyleBackColor = true;
            this.completeRadioButton.CheckedChanged += new System.EventHandler(this.completeRadioButton_CheckedChanged);
            // 
            // inProgressRadioButton
            // 
            this.inProgressRadioButton.AutoSize = true;
            this.inProgressRadioButton.Location = new System.Drawing.Point(47, 378);
            this.inProgressRadioButton.Name = "inProgressRadioButton";
            this.inProgressRadioButton.Size = new System.Drawing.Size(126, 17);
            this.inProgressRadioButton.TabIndex = 4;
            this.inProgressRadioButton.TabStop = true;
            this.inProgressRadioButton.Text = "In Progress Requests";
            this.inProgressRadioButton.UseVisualStyleBackColor = true;
            this.inProgressRadioButton.CheckedChanged += new System.EventHandler(this.inProgressRadioButton_CheckedChanged);
            // 
            // OutstandingRadioButton
            // 
            this.OutstandingRadioButton.AutoSize = true;
            this.OutstandingRadioButton.Location = new System.Drawing.Point(47, 325);
            this.OutstandingRadioButton.Name = "OutstandingRadioButton";
            this.OutstandingRadioButton.Size = new System.Drawing.Size(130, 17);
            this.OutstandingRadioButton.TabIndex = 3;
            this.OutstandingRadioButton.TabStop = true;
            this.OutstandingRadioButton.Text = "Outstanding Requests";
            this.OutstandingRadioButton.UseVisualStyleBackColor = true;
            this.OutstandingRadioButton.CheckedChanged += new System.EventHandler(this.OutstandingRadioButton_CheckedChanged);
            // 
            // viewIssuesDataGridView
            // 
            this.viewIssuesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.viewIssuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewIssuesDataGridView.Location = new System.Drawing.Point(148, 46);
            this.viewIssuesDataGridView.Name = "viewIssuesDataGridView";
            this.viewIssuesDataGridView.Size = new System.Drawing.Size(557, 263);
            this.viewIssuesDataGridView.TabIndex = 1;
            this.viewIssuesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewIssuesDataGridView_CellContentClick);
            // 
            // viewIssuesButton
            // 
            this.viewIssuesButton.Location = new System.Drawing.Point(47, 106);
            this.viewIssuesButton.Name = "viewIssuesButton";
            this.viewIssuesButton.Size = new System.Drawing.Size(95, 23);
            this.viewIssuesButton.TabIndex = 0;
            this.viewIssuesButton.Text = "View All Issues";
            this.viewIssuesButton.UseVisualStyleBackColor = true;
            this.viewIssuesButton.Click += new System.EventHandler(this.viewIssuesButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.viewUsersTab);
            this.tabControl1.Controls.Add(this.addDeleteUserTab);
            this.tabControl1.Controls.Add(this.changePermissionTab);
            this.tabControl1.Controls.Add(this.viewIssuesTab);
            this.tabControl1.Controls.Add(this.updateDetailsTab);
            this.tabControl1.Controls.Add(this.banUserTab);
            this.tabControl1.Controls.Add(this.contactUserTab);
            this.tabControl1.Controls.Add(this.viewStatsTab);
            this.tabControl1.Controls.Add(this.logoffTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 569);
            this.tabControl1.TabIndex = 0;
            // 
            // viewUsersTab
            // 
            this.viewUsersTab.Controls.Add(this.viewUsersDataGridView);
            this.viewUsersTab.Controls.Add(this.viewUsersButton);
            this.viewUsersTab.Controls.Add(this.button1);
            this.viewUsersTab.Location = new System.Drawing.Point(4, 22);
            this.viewUsersTab.Name = "viewUsersTab";
            this.viewUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewUsersTab.Size = new System.Drawing.Size(713, 543);
            this.viewUsersTab.TabIndex = 0;
            this.viewUsersTab.Text = "View Users";
            this.viewUsersTab.UseVisualStyleBackColor = true;
            // 
            // viewUsersDataGridView
            // 
            this.viewUsersDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.viewUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewUsersDataGridView.Location = new System.Drawing.Point(101, 3);
            this.viewUsersDataGridView.Name = "viewUsersDataGridView";
            this.viewUsersDataGridView.Size = new System.Drawing.Size(612, 548);
            this.viewUsersDataGridView.TabIndex = 7;
            this.viewUsersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewUsersDataGridView_CellContentClick);
            // 
            // viewUsersButton
            // 
            this.viewUsersButton.Location = new System.Drawing.Point(6, 16);
            this.viewUsersButton.Name = "viewUsersButton";
            this.viewUsersButton.Size = new System.Drawing.Size(95, 23);
            this.viewUsersButton.TabIndex = 6;
            this.viewUsersButton.Text = "View All Users";
            this.viewUsersButton.UseVisualStyleBackColor = true;
            this.viewUsersButton.Click += new System.EventHandler(this.viewUsersButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, -22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addDeleteUserTab
            // 
            this.addDeleteUserTab.Controls.Add(this.panel2);
            this.addDeleteUserTab.Controls.Add(this.panel1);
            this.addDeleteUserTab.Location = new System.Drawing.Point(4, 22);
            this.addDeleteUserTab.Name = "addDeleteUserTab";
            this.addDeleteUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.addDeleteUserTab.Size = new System.Drawing.Size(713, 543);
            this.addDeleteUserTab.TabIndex = 1;
            this.addDeleteUserTab.Text = "Add / Delete User";
            this.addDeleteUserTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectRoleComboBox);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.addUserButton);
            this.panel2.Controls.Add(this.DOBTextbox);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.emailTextbox);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.passwordTextbox);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.lastnameTextbox);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.firstnameTextbox);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.usernameTextbox);
            this.panel2.Location = new System.Drawing.Point(46, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 357);
            this.panel2.TabIndex = 45;
            // 
            // selectRoleComboBox
            // 
            this.selectRoleComboBox.FormattingEnabled = true;
            this.selectRoleComboBox.Items.AddRange(new object[] {
            "Shareholder",
            "Broker",
            "Stock Exchange Manager"});
            this.selectRoleComboBox.Location = new System.Drawing.Point(110, 221);
            this.selectRoleComboBox.Name = "selectRoleComboBox";
            this.selectRoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectRoleComboBox.TabIndex = 46;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(63, 224);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Role";
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(110, 259);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 44;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // DOBTextbox
            // 
            this.DOBTextbox.Location = new System.Drawing.Point(110, 191);
            this.DOBTextbox.Name = "DOBTextbox";
            this.DOBTextbox.Size = new System.Drawing.Size(100, 20);
            this.DOBTextbox.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 194);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Date of birth";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(110, 165);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(60, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Email";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(49, 88);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(110, 85);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 38;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(47, 116);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "First name";
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.Location = new System.Drawing.Point(110, 139);
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextbox.TabIndex = 36;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(46, 142);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "Last name";
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.Location = new System.Drawing.Point(110, 113);
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextbox.TabIndex = 34;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "Username";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(110, 56);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteUserButton);
            this.panel1.Controls.Add(this.usernameTextbox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(397, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 148);
            this.panel1.TabIndex = 44;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(69, 74);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserButton.TabIndex = 43;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // usernameTextbox1
            // 
            this.usernameTextbox1.Location = new System.Drawing.Point(69, 31);
            this.usernameTextbox1.Name = "usernameTextbox1";
            this.usernameTextbox1.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox1.TabIndex = 30;
            this.usernameTextbox1.TextChanged += new System.EventHandler(this.usernameTextbox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Username";
            // 
            // changePermissionTab
            // 
            this.changePermissionTab.Controls.Add(this.selectRoleComboBox1);
            this.changePermissionTab.Controls.Add(this.label9);
            this.changePermissionTab.Controls.Add(this.changePermissionButton);
            this.changePermissionTab.Controls.Add(this.label8);
            this.changePermissionTab.Controls.Add(this.usernameTextbox2);
            this.changePermissionTab.Location = new System.Drawing.Point(4, 22);
            this.changePermissionTab.Name = "changePermissionTab";
            this.changePermissionTab.Padding = new System.Windows.Forms.Padding(3);
            this.changePermissionTab.Size = new System.Drawing.Size(713, 543);
            this.changePermissionTab.TabIndex = 2;
            this.changePermissionTab.Text = "Change Permission";
            this.changePermissionTab.UseVisualStyleBackColor = true;
            // 
            // selectRoleComboBox1
            // 
            this.selectRoleComboBox1.FormattingEnabled = true;
            this.selectRoleComboBox1.Items.AddRange(new object[] {
            "System Administrator",
            "Shareholder",
            "Broker",
            "Stock Exchange Manager"});
            this.selectRoleComboBox1.Location = new System.Drawing.Point(93, 91);
            this.selectRoleComboBox1.Name = "selectRoleComboBox1";
            this.selectRoleComboBox1.Size = new System.Drawing.Size(121, 21);
            this.selectRoleComboBox1.TabIndex = 48;
            this.selectRoleComboBox1.SelectedIndexChanged += new System.EventHandler(this.selectRoleComboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Role";
            // 
            // changePermissionButton
            // 
            this.changePermissionButton.Location = new System.Drawing.Point(93, 132);
            this.changePermissionButton.Name = "changePermissionButton";
            this.changePermissionButton.Size = new System.Drawing.Size(121, 23);
            this.changePermissionButton.TabIndex = 46;
            this.changePermissionButton.Text = "Change Permission";
            this.changePermissionButton.UseVisualStyleBackColor = true;
            this.changePermissionButton.Click += new System.EventHandler(this.changePermissionButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Username";
            // 
            // usernameTextbox2
            // 
            this.usernameTextbox2.Location = new System.Drawing.Point(93, 54);
            this.usernameTextbox2.Name = "usernameTextbox2";
            this.usernameTextbox2.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox2.TabIndex = 44;
            this.usernameTextbox2.TextChanged += new System.EventHandler(this.usernameTexbox2_TextChanged);
            // 
            // logoffTab
            // 
            this.logoffTab.Controls.Add(this.logoffButton);
            this.logoffTab.Location = new System.Drawing.Point(4, 22);
            this.logoffTab.Name = "logoffTab";
            this.logoffTab.Padding = new System.Windows.Forms.Padding(3);
            this.logoffTab.Size = new System.Drawing.Size(713, 543);
            this.logoffTab.TabIndex = 8;
            this.logoffTab.Text = "Log Off";
            this.logoffTab.UseVisualStyleBackColor = true;
            // 
            // logoffButton
            // 
            this.logoffButton.Location = new System.Drawing.Point(610, 3);
            this.logoffButton.Name = "logoffButton";
            this.logoffButton.Size = new System.Drawing.Size(75, 23);
            this.logoffButton.TabIndex = 0;
            this.logoffButton.Text = "Log off now";
            this.logoffButton.UseVisualStyleBackColor = true;
            this.logoffButton.Click += new System.EventHandler(this.logoffButton_Click);
            // 
            // adminSystemMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 569);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminSystemMain";
            this.Text = "Admin System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.adminSystemMain_Load);
            this.viewStatsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.banUserTab.ResumeLayout(false);
            this.banUserTab.PerformLayout();
            this.updateDetailsTab.ResumeLayout(false);
            this.updateDetailsTab.PerformLayout();
            this.viewIssuesTab.ResumeLayout(false);
            this.viewIssuesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewIssuesDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.viewUsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersDataGridView)).EndInit();
            this.addDeleteUserTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.changePermissionTab.ResumeLayout(false);
            this.changePermissionTab.PerformLayout();
            this.logoffTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage viewStatsTab;
        private System.Windows.Forms.TabPage contactUserTab;
        private System.Windows.Forms.TabPage banUserTab;
        private System.Windows.Forms.TabPage updateDetailsTab;
        private System.Windows.Forms.TabPage viewIssuesTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addDeleteUserTab;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox usernameTextbox1;
        private System.Windows.Forms.TabPage logoffTab;
        private System.Windows.Forms.Button logoffButton;
        private System.Windows.Forms.TabPage viewUsersTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage changePermissionTab;
        private System.Windows.Forms.ComboBox selectRoleComboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button changePermissionButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox usernameTextbox2;
        private System.Windows.Forms.ComboBox selectRoleComboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button updateUserDetailButton;
        private System.Windows.Forms.TextBox DOBTextbox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox emailTextbox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox passwordTextbox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lastNameTextbox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox firstNameTextbox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox usernameTextbox3;
        private System.Windows.Forms.DataGridView viewIssuesDataGridView;
        private System.Windows.Forms.Button viewIssuesButton;
        private System.Windows.Forms.RadioButton completeRadioButton;
        private System.Windows.Forms.RadioButton inProgressRadioButton;
        private System.Windows.Forms.RadioButton OutstandingRadioButton;
        private System.Windows.Forms.Button banUserbutton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox banUserTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox selectRoleComboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox DOBTextbox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView viewUsersDataGridView;
        private System.Windows.Forms.Button viewUsersButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button viewChartButton;



    }
}
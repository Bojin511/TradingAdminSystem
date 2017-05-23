using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class adminSystemMain : Form
    {
        public adminSystemMain()
        {
            InitializeComponent();
        }


        private void addUserTab_Click(object sender, EventArgs e)
        {

        }

        static XDocument xdoc = null;



        private void addUserButton_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(@"../../Users.xml");
            insertUser();
            MessageBox.Show("User has been added");
        }

        private void insertUser()
        {
            XElement xUsr = new XElement("USER",
                            new XElement("USERNAME", usernameTextbox.Text),
                            new XElement("PASSWORD", passwordTextbox.Text),
                            new XElement("FIRST_NAME", firstnameTextbox.Text),
                            new XElement("LAST_NAME", lastnameTextbox.Text),
                            new XElement("EMAIL", emailTextbox.Text),
                            new XElement("DOB", DOBTextbox.Text),
                            new XElement("ROLE", selectRoleComboBox.Text));

            xdoc.Element("USERS").Add(xUsr);
            xdoc.Save(@"../../Users.xml");
        }


        private void usernameTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(@"../../Users.xml");
            deleteUserByUsername(usernameTextbox1.Text);
            MessageBox.Show("User has been deleted");
        }

        private void deleteUserByUsername(string username)
        {
            var query = (from usr in xdoc.Descendants("USER")
                         where usr.Element("USERNAME").Value == username
                         select usr);
            query.Remove();
            xdoc.Save(@"../../Users.xml");

        }

        private void logoffButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectRoleComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void changePermissionButton_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(@"../../Users.xml");
            changePermissionByUsername(usernameTextbox2.Text);
            MessageBox.Show("User permission has been changed");
        }

        private void changePermissionByUsername(string username)
        {
            var query = (from usr in xdoc.Descendants("USER")
                         where usr.Element("USERNAME").Value == username
                         select usr);

            foreach (var usr in query)
            { usr.SetElementValue("ROLE", selectRoleComboBox1.Text); }

            xdoc.Save(@"../../Users.xml");

        }

        private void usernameTexbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateUserDetailButton_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(@"../../Users.xml");
            updateUserDetailByUsername(usernameTextbox3.Text);
            MessageBox.Show("User details have been changed");
        }

        private void updateUserDetailByUsername(string username1)
        {
            var query = (from usr in xdoc.Descendants("USER")
                         where usr.Element("USERNAME").Value == username1
                         select usr);

            foreach (var usr in query)
            {
                usr.SetElementValue("USERNAME", usernameTextbox3.Text);
                usr.SetElementValue("PASSWORD", passwordTextbox3.Text);
                usr.SetElementValue("FIRST_NAME", firstNameTextbox3.Text);
                usr.SetElementValue("LAST_NAME", lastNameTextbox3.Text);
                usr.SetElementValue("EMAIL", emailTextbox3.Text);
                usr.SetElementValue("DOB", DOBTextbox3.Text);
            }

            xdoc.Save(@"../../Users.xml");
            xdoc.Save(@"../../Backup.xml");

        }

        private void viewIssuesButton_Click(object sender, EventArgs e)
        {
            XDocument xdoc = null;
            xdoc = XDocument.Load(@"../../UserRequests.xml");

            XElement xReq = new XElement("REQUEST",
                            new XElement("USERNAME"),
                            new XElement("ISSUE"),
                            new XElement("DATE"),
                            new XElement("STATUS"),
                            new XElement("DESCRIPTION"));

            var result = from req in xdoc.Descendants("REQUEST")
                         select new
                         {
                             username = req.Element("USERNAME").Value,
                             issue = req.Element("ISSUE").Value,
                             date = req.Element("DATE").Value,
                             status = req.Element("STATUS").Value,
                             description = req.Element("DESCRIPTION").Value
                         };

            viewIssuesDataGridView.DataSource = result.ToList();
        }

        private void OutstandingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            XDocument xdoc = null;
            xdoc = XDocument.Load(@"../../UserRequests.xml");

            XElement xReq = new XElement("REQUEST",
                            new XElement("USERNAME"),
                            new XElement("ISSUE"),
                            new XElement("DATE"),
                            new XElement("STATUS"),
                            new XElement("DESCRIPTION"));

            var result = from req in xdoc.Descendants("REQUEST")
                         where req.Element("STATUS").Value == "Outstanding"
                         select new
                         {
                             username = req.Element("USERNAME").Value,
                             issue = req.Element("ISSUE").Value,
                             date = req.Element("DATE").Value,
                             status = req.Element("STATUS").Value,
                             description = req.Element("DESCRIPTION").Value
                         };

            viewIssuesDataGridView.DataSource = result.ToList();
        }

        private void inProgressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            XDocument xdoc = null;
            xdoc = XDocument.Load(@"../../UserRequests.xml");

            XElement xReq = new XElement("REQUEST",
                            new XElement("USERNAME"),
                            new XElement("ISSUE"),
                            new XElement("DATE"),
                            new XElement("STATUS"),
                            new XElement("DESCRIPTION"));

            var result = from req in xdoc.Descendants("REQUEST")
                         where req.Element("STATUS").Value == "In Progress"
                         select new
                         {
                             username = req.Element("USERNAME").Value,
                             issue = req.Element("ISSUE").Value,
                             date = req.Element("DATE").Value,
                             status = req.Element("STATUS").Value,
                             description = req.Element("DESCRIPTION").Value
                         };

            viewIssuesDataGridView.DataSource = result.ToList();
        }

        private void completeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            XDocument xdoc = null;
            xdoc = XDocument.Load(@"../../UserRequests.xml");

            XElement xReq = new XElement("REQUEST",
                            new XElement("USERNAME"),
                            new XElement("ISSUE"),
                            new XElement("DATE"),
                            new XElement("STATUS"),
                            new XElement("DESCRIPTION"));

            var result = from req in xdoc.Descendants("REQUEST")
                         where req.Element("STATUS").Value == "Completed"
                         select new
                         {
                             username = req.Element("USERNAME").Value,
                             issue = req.Element("ISSUE").Value,
                             date = req.Element("DATE").Value,
                             status = req.Element("STATUS").Value,
                             description = req.Element("DESCRIPTION").Value
                         };

            viewIssuesDataGridView.DataSource = result.ToList();
        }

        private void viewIssuesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void banUserbutton_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(@"../../Users.xml");
            banUserByUsername(banUserTextBox.Text);
            MessageBox.Show("User has been banned");
        }

        private void banUserByUsername(string username)
        {
            var query = (from usr in xdoc.Descendants("USER")
                         where usr.Element("USERNAME").Value == username
                         select usr);
            query.Remove();
            xdoc.Save(@"../../Users.xml");

        }

        private void banUserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminSystemMain_Load(object sender, EventArgs e)
        {

        }

        private void lastnameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewUsersButton_Click(object sender, EventArgs e)
        {
            XDocument xdoc = null;
            xdoc = XDocument.Load(@"../../Users.xml");

            XElement xReq = new XElement("USER",
                            new XElement("USERNAME"),
                            new XElement("PASSWORD"),
                            new XElement("FIRST_NAME"),
                            new XElement("LAST_NAME"),
                            new XElement("EMAIL"),
                            new XElement("DOB"),
                            new XElement("ROLE")
                            );

            var result = from usr in xdoc.Descendants("USER")
                         select new
                         {
                             username = usr.Element("USERNAME").Value,
                             password = usr.Element("PASSWORD").Value,
                             firstname = usr.Element("FIRST_NAME").Value,
                             lastname = usr.Element("LAST_NAME").Value,
                             email = usr.Element("EMAIL").Value,
                             dob = usr.Element("DOB").Value,
                             role = usr.Element("ROLE").Value
                         };

            viewUsersDataGridView.DataSource = result.ToList();
        }

        private void viewUsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void viewChartButton_Click(object sender, EventArgs e)
        {
             XmlDocument doc = new XmlDocument();
             doc.Load(@"../../loginLog.xml");

             int count = doc.SelectNodes("LOGINS/LOGIN").Count;
             //MessageBox.Show(count.ToString());
             int NoSuccessCount = doc.SelectNodes("LOGINS/LOGIN/ATTEMPT[. = \"Success\"]").Count;
             MessageBox.Show("Number of success login is " + NoSuccessCount.ToString());
             int NoFailedCount = doc.SelectNodes("LOGINS/LOGIN/ATTEMPT[. = \"Failed\"]").Count;
             MessageBox.Show("Number of failed login is " + NoFailedCount.ToString());

            chart1.ChartAreas.Add("area");
            chart1.ChartAreas["area"].AxisX.Minimum = 0;
            chart1.ChartAreas["area"].AxisX.Maximum = 10;
            chart1.ChartAreas["area"].AxisX.Interval = 5;
            chart1.ChartAreas["area"].AxisY.Minimum = 0;
            chart1.ChartAreas["area"].AxisY.Maximum = 30;
            chart1.ChartAreas["area"].AxisY.Interval = 2;

            chart1.Series.Add("Success");
            chart1.Series.Add("Failed");

            chart1.Series["Success"].Color = Color.Green;
            chart1.Series["Failed"].Color = Color.Red;

            chart1.Series["Success"].Points.AddXY(0, 0);
            chart1.Series["Failed"].Points.AddXY(0, 0);

            chart1.Series["Success"].Points.AddXY(1, NoSuccessCount);
            chart1.Series["Failed"].Points.AddXY(1, NoFailedCount);



     
      

    
  }
}


        }





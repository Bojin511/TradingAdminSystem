using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class userRegisterPage : Form
    {
        public userRegisterPage()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        static XDocument xdoc = null;

        private void submitButton_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(@"../../Users.xml");
            insertUser();
            this.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}

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
    public partial class userRequestForm : Form
    {
        public userRequestForm()
        {
            InitializeComponent();
        }

        private void userRequestForm_Load(object sender, EventArgs e)
        {

        }

        static XDocument xdoc = null;

        private void sendRequestButton_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(@"../../UserRequests.xml");
            addRequest();
            this.Close();
        }

        private void addRequest()
        {
            XElement xReq = new XElement("REQUEST",
                            new XElement("USERNAME", usernameTextbox.Text),
                            new XElement("ISSUE", passwordTextbox.Text),
                            new XElement("DATE", dateTimePicker1.Text),
                            new XElement("DESCRIPTION", descriptionTextbox.Text),
                            new XElement("STATUS", statusComboBox.Text));

            xdoc.Element("REQUESTS").Add(xReq);
            xdoc.Save(@"../../UserRequests.xml");
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void descriptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Utils;

namespace WindowsFormsApplication1
{
    public partial class adminLoginPage : Form
    {
        public adminLoginPage()
        {
            InitializeComponent();
        }

        static XDocument xdoc = null;

        private void login_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(@"../../Users.xml");
            //validate(userNameTextBox.Text, passwordTextBox.Text);
            int c = UserValidator.getUserByUsername( userNameTextBox.Text, passwordTextBox.Text, xdoc);
            if (c != 0)
            {
                new adminSystemMain().Show();

                UserLoginLogger.logSuccess(userNameTextBox.Text);
            }
            else
            { 
                MessageBox.Show("Incorrect Username / Password");

                UserLoginLogger.logFailed(userNameTextBox.Text);
            
            }
        }


       


        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void registerPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {        
            userRegisterPage f = new userRegisterPage();
            f.Show();
        }


        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void sendRequestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userRequestForm f = new userRequestForm();
            f.Show();
        }

    }
 }


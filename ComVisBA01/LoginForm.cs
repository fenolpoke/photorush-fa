using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComVisBA01
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            Data.Users[0] = new User();
            Data.Users[0].Name = "Yuli Amelia";
            Data.Users[0].Username = "admin";
            Data.Users[0].Password = "admin";
            Data.Users[0].Email = "Yuli@Amelia";
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //RegisterForm register = new RegisterForm();
            //register.Show();
            //this.Hide();
            Dispose();
            new RegisterForm().ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please Fill Your Username");
                usernameTextBox.Focus();
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Plese Fill Your Password");
                passwordTextBox.Focus();
            }
            else
            {
                Boolean UsernameFound = false;

                for (int i = 0; i < Data.UserCount; i++)
                {
                    if (usernameTextBox.Text.Equals(Data.Users[i].Username))
                    {
                        UsernameFound = true;
                        if (passwordTextBox.Text.Equals(Data.Users[i].Password))
                        {
                            MessageBox.Show("Login success!");
                            Dispose();
                            new HomePage().ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password!");
                            passwordTextBox.Focus();
                        }
                    }
                }

                if (!UsernameFound)
                {
                    MessageBox.Show("Username not found!");
                    registerLinkLabel.Focus();
                }
            }
        }
    }
}

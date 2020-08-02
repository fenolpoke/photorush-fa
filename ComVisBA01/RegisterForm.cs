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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public RegisterForm(string pass)
        {
            InitializeComponent();
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //LoginForm login = new LoginForm();
            //login.Show();
            //this.Hide();
            Dispose();
            new LoginForm().ShowDialog();
            
        }

        private Boolean isAlnum(String text)
        {
            Boolean alpha = false, numeric = false;
            foreach (Char character in text)
            {
                if (Char.IsLetter(character)) alpha = true;
                if (Char.IsDigit(character)) numeric = true;
            }
            if (!alpha || !numeric) return false;
            else return true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            

            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please Fill Your Name ");
                nameTextBox.Focus();
            }
            else if (nameTextBox.TextLength < 3 || nameTextBox.TextLength > 20)
            {
                MessageBox.Show("Please Fill Name With 3 To 20 Characters ");
                nameTextBox.Focus();
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please Fill Your Username ");
                usernameTextBox.Focus();
            }
            else if (usernameTextBox.TextLength < 3 || usernameTextBox.TextLength > 15)
            {
                MessageBox.Show("Please Fill Username With 3 To 15 Characters ");
                usernameTextBox.Focus();
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please Fill Your Password ");
                passwordTextBox.Focus();
            }
            else if(passwordTextBox.TextLength < 6 || passwordTextBox.TextLength > 20 )
            {
                MessageBox.Show("Please Fill Password With 6 To 20 Characters ");
                passwordTextBox.Focus();
            }
            else if (!isAlnum(passwordTextBox.Text))
            {
                MessageBox.Show("Please Fill Password With Alphanumeric Characters");
                passwordTextBox.Focus();
            }
            else if (emailTextBox.Text == "")
            {
                MessageBox.Show("Please Fill Your Email");
                emailTextBox.Focus();
            }
            else if (!emailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Please Fill Email With The Correct Format ");
                emailTextBox.Focus();
            }
            else
            {
                //LoginForm login = new LoginForm();
                //login.Show();
                //this.Hide();
                Data.Users[Data.UserCount] = new User();
                
                Data.Users[Data.UserCount].Name = nameTextBox.Text;
                Data.Users[Data.UserCount].Username = usernameTextBox.Text;
                Data.Users[Data.UserCount].Password = passwordTextBox.Text;
                Data.Users[Data.UserCount].Email = emailTextBox.Text;
                Data.UserCount++;

                MessageBox.Show("Login Success! Please Login");
                
                Dispose();
                new LoginForm().ShowDialog();
            }
          
        }
           
    }
}

using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIC;
using System.IO;

namespace UI
{
    public partial class Login_Form : Form
    {
        private User_Service user_service;
        public Login_Form()
        {
            InitializeComponent();
            user_service = new User_Service();
            //check if file is present
            if (File.Exists("logindetails.txt"))
            {
                StreamReader sr = new StreamReader("logindetails.txt");
                string s = sr.ReadToEnd();
                string[] s1 = s.Split('|');
                txtusername.Text = s1[0];
                txtpassword.Text = s1[1];
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            User user = new User();

            // set the entered data to the username and password of the employee

            user.Username = username;
            user.Password = password;

            User_Service user_Service = new User_Service();

            bool IsValidUser = user_Service.ValidateUser(user);

            if (IsValidUser==true)
            {
                //Done by Sam Lo
                user = user_service.GetUserByLogin(username, password);
                MessageBox.Show("Welcome " + user.FullName);

                //Done by abhishek
                //Menu_Form.GetLooggedInUser = user;
                // hide the login page
                this.Hide();
                // move to next screen
                Menu_Form menu_Form = new Menu_Form(user);
                menu_Form.Show();

            }
            else
            {
                // if invaild details produced we put an error message
                MessageBox.Show("Invalid Credentials, please try again with correct login credentials");
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void checkbxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (txtusername.Text != string.Empty && txtpassword.Text != string.Empty)
            {
                StreamWriter sw = new StreamWriter("logindetails.txt");
                sw.Write(txtusername.Text + "|" + txtpassword.Text);
                sw.Close();
            }
        }
    }
}

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

namespace UI
{
    public partial class UserCreate_Form : Form//Done by Sam Lo
    {
        private User_Service User_Service;
        private User user;

        public UserCreate_Form(User user)
        {
            User_Service = new User_Service();
            this.user = user;
            InitializeComponent();
        }

        private void UsersCrud_Form_Load(object sender, EventArgs e)
        {
            combo_usertype.Items.Add(UserType.admin);
            combo_usertype.Items.Add(UserType.endUser);

        }

        private void btn_createUser_Click(object sender, EventArgs e)
        {

            string message = "are you sure about this";
            string title = "Add user";

            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, btns);

            if (result == DialogResult.Yes)
            {
                //code to clear
                CreateUser();
                MessageBox.Show("User has been added");
                UsersManage_Form usersManage_Form = new UsersManage_Form(user);
                usersManage_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not Canceled");
                return;
            }

        }

        private void CreateUser()
        {
            User u = new User
            {
                FirstName = txt_firstName.Text,
                LastName = txt_lastName.Text,
                userType = (UserType)combo_usertype.SelectedIndex,
                EmailAddress = txt_email.Text,
                PhoneNumber = txt_number.Text,
                Username = txt_username.Text,
                Password = txt_pass.Text

            };
            User_Service.AddNewUser(u);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            string message = "are you sure you want to cancel";
            string title = "Cancel";

            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, btns);

            if (result == DialogResult.Yes)
            {
                //code to clear
                MessageBox.Show("User has not been added");
                UsersManage_Form usersManage_Form = new UsersManage_Form(user);
                usersManage_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not Canceled");
                return;
            }
        }
    }
}

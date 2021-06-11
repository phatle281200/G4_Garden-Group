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
using MODEL;

namespace UI
{
    public partial class UserEdit_Form : Form//Done by Sam Lo
    {
        private User user;
        private User_Service user_Service;
        private UsersManage_Form usersManage;
        public UserEdit_Form(User user)
        {
            user_Service = new User_Service();
            usersManage = new UsersManage_Form(user);
            this.user = user;
            InitializeComponent();
        }
        private void UserEdit_Form_Load(object sender, EventArgs e)
        {
            FillForm(user);
            combo_usertype.Items.Add(UserType.admin);
            combo_usertype.Items.Add(UserType.endUser);
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure about this?";
            string title = "Confirm Changes";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(title, msg, btns);

            if (dialogResult == DialogResult.Yes)
            {

                EditUser(user);
                user_Service.EditUser(user);
                usersManage.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void EditUser(User user)
        {
            user.FirstName = txt_firstName.Text;
            user.LastName = txt_lastName.Text;
            user.EmailAddress = txt_email.Text;
            user.PhoneNumber = txt_number.Text;
            user.userType = (UserType)combo_usertype.SelectedIndex;
            user.Username = txt_username.Text;
            user.Password = txt_password.Text;
        }
        private void FillForm(User user)
        {
            lbl_fullname.Text = user.FullName;
            txt_firstName.Text = user.FirstName;
            txt_lastName.Text = user.LastName;
            txt_email.Text = user.EmailAddress;
            txt_number.Text = user.PhoneNumber;
            //txt_username.Text = user.Username;
            //txt_password.Text = user.Password;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure about this?";
            string title = "Cancel Editing";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(title, msg, btns);

            if (dialogResult == DialogResult.Yes)
            {
                usersManage.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure about this?";
            string title = "Delete User";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(title, msg, btns);

            if (dialogResult == DialogResult.Yes)
            {
                user_Service.RemoveUser(user);
                usersManage.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

    }
}

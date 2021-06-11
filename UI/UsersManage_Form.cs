using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using LOGIC;
using MongoDB.Bson;
using MongoDB.Driver;

namespace UI
{
    public partial class UsersManage_Form : Form //Done by Sam Lo
    {

        private User_Service user_service;
        private Incident_Service incident_service;
        private List<User> users;
        private User user;

        public UsersManage_Form(User user)
        {
            this.user = user;
            user_service = new User_Service();
            incident_service = new Incident_Service();
            users = new List<User>();
            InitializeComponent();

        }

        private void UsersManage_Form_Load(object sender, EventArgs e)
        {
            if (user.userType == UserType.endUser)
            {
                btn_edit.Visible = false;
                btn_addUser.Visible = false;
                btn_addUser.Update();
                btn_edit.Update();
            }
            FillUsersListview();
            
        }
        private void btn_addUser_Click(object sender, EventArgs e)
        {

            UserCreate_Form userCreate =  new UserCreate_Form(user);
            userCreate.Show();
            this.Hide();
        }

        private void FillUsersListview()
        {
            listview_Users.Items.Clear();
            users = user_service.GetAllUsers();
            
            foreach (User u in users)
            {
                u.IncidentAmount = incident_service.GetUserIncidents(u);
                ListViewItem item = new ListViewItem(u.User_Id.ToString());
                item.SubItems.Add(u.EmailAddress);
                item.SubItems.Add(u.FirstName);
                item.SubItems.Add(u.LastName);
                item.SubItems.Add(u.IncidentAmount.ToString());
                listview_Users.Items.Add(item);

            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (listview_Users.SelectedItems.Count == 0)
            {
                MessageBox.Show("No user selected");
                return;
            }
            else
            {
                ListViewItem item = listview_Users.SelectedItems[0];
                string id = item.SubItems[0].Text;
                User u = user_service.GetUser(id);
                UserEdit_Form userEdit_Form = new UserEdit_Form(u);
                userEdit_Form.Show();
                this.Hide();
            }
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            //menu does not work properly
            Menu_Form menu_Form = new Menu_Form(user);
            menu_Form.Show();
            this.Hide();
        }


    }
}

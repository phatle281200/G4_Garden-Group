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

namespace UI
{
    // done by abhishek
    public partial class Menu_Form : Form//done by abhishek
    {
        private User user;
        //public static User  GetLooggedInUser { get; set; }//why?
        public Menu_Form(User user)
        {
            this.user = user;

            InitializeComponent();
            
            //doesnt work
            /*
            if (GetLooggedInUser.userType==UserType.endUser)
            {
                userManagementToolStripMenuItem.Visible = false;
            }*/

        }
        private void Menu_Form_Load(object sender, EventArgs e)
        {

        }

        private void dashboardStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard_form statistics = new Dashboard_form();
            statistics.Show();
        }

        private void ticketOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncidentDisplay_Form incidentDisplay = new IncidentDisplay_Form();
            incidentDisplay.Show();
        }

        private void addIncidentTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncidentsCRUD_Form incidentsCRUD = new IncidentsCRUD_Form();
            incidentsCRUD.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UsersManage_Form usersManage = new UsersManage_Form(user);
            usersManage.Show();

        }



        private void transferIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferIncidentPage transferIncidentPage = new TransferIncidentPage();
            transferIncidentPage.Show();
        }

    }
}

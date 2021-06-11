using DAL;
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
    public partial class TransferIncidentPage : Form
    {

        public TransferIncidentPage()
        {
            InitializeComponent();
            combobxIncident.DataSource = new Incident_DAO().GetIncidents();
            combobxUsers.DataSource = new User_DAO().GetAllUsers();
        }

        private void btnTransferTicket_Click(object sender, EventArgs e)
        {
            Incident i = new Incident();
            i = (Incident)combobxIncident.SelectedItem;

            i.IncidentOwner = ((User)combobxUsers.SelectedItem).EmailAddress;
            new Incident_DAO().UpdateIncident(i);
        }
    }
}

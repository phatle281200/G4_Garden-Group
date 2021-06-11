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
using DAL;

namespace UI
{
    public partial class Dashboard_form : Form
    {
        private Incident_Service incidentService;
        private List<Incident> openedIncidents;
        private List<Incident> allIncidents;
        int PastDl = 0;

        public Dashboard_form()
        {
            InitializeComponent();
            incidentService = new Incident_Service();
            
            
        }
        private void LoadForm()
        {
            allIncidents = incidentService.GetIncidents();
            openedIncidents = incidentService.GetInProgressIncidents();
            int openIncidents = openedIncidents.Count();
            int total = allIncidents.Count();
            foreach (Incident i in allIncidents)
            {
                if (DateTime.Now > i.IncidentDeadline)
                {
                    PastDl++;
                }
            }
            lblunresolved.Text = PastDl.ToString();
            lblAll.Text = allIncidents.ToString();
            
        }
        private void btnShowList_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}

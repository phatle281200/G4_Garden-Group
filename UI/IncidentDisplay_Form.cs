using LOGIC;
using MODEL;
using MongoDB.Bson;
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
    public partial class IncidentDisplay_Form : Form
    {
        private Incident_Service Incident_Service = new Incident_Service();
        public IncidentDisplay_Form()
        {
            InitializeComponent();
        }

        private void btnEmailFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnEmailFilter_Click_1(object sender, EventArgs e)
        {

        }

        private void IncidentDisplay_Form_Load(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.Columns.Add("_Id", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Reported By User", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("SubjectEmail", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("IncidentType", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("IncidentPriority", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Happend At:", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Deadline", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Status", 100, HorizontalAlignment.Left);

            RefreshListView();
        }
        private void RefreshListView()
        {
            listView1.Items.Clear();
            List<Incident> incidents = Incident_Service.GetIncidents();
            foreach (Incident incident in incidents)
            {
                ListViewItem items = new ListViewItem(incident._id.ToString());
                items.Tag = incident._id.ToString();

                items.SubItems.Add(incident.ReportedUser);
                items.SubItems.Add(incident.SubjectEmail);
                items.SubItems.Add(incident.IncidentType.ToString());
                items.SubItems.Add(incident.IncidentPriority.ToString());
                items.SubItems.Add(incident.TheReportedFullTime.ToString());
                items.SubItems.Add(incident.IncidentDeadline.ToString());
                items.SubItems.Add(incident.Description);
                items.SubItems.Add(incident.Status.ToString());
                listView1.Items.Add(items);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            listView1.SelectedItems.Clear();
            if (listView1.SelectedItems.Count > 0)
            {
                string item = listView1.SelectedItems[0].Tag.ToString();
                ObjectId objectId = new ObjectId(item);
                Incident_Service.RemoveIncident(objectId);
                RefreshListView();
            }
        }
    }
}

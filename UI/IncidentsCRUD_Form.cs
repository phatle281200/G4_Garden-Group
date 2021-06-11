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
    public partial class IncidentsCRUD_Form : Form
    {
        private LOGIC.Incident_Service incident_Service = new LOGIC.Incident_Service();
        public IncidentsCRUD_Form()
        {
            InitializeComponent();
        }

        private void IncidentsCRUD_Form_Load(object sender, EventArgs e)
        {

            cmbIncidentPriority.DataSource = Enum.GetValues(typeof(MODEL.IncidentPriority));
            cmbIncidentType.DataSource = Enum.GetValues(typeof(MODEL.IncidentType));
            cmbStatus.DataSource = Enum.GetValues(typeof(MODEL.Status));
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MODEL.Incident incident = new MODEL.Incident();
            incident.SubjectEmail = txtEmail.Text;
            incident.ReportedUser = txtUserID.Text;
            incident.IncidentType = (MODEL.IncidentType)cmbIncidentType.SelectedItem;
            incident.IncidentPriority = (MODEL.IncidentPriority)cmbIncidentPriority.SelectedItem;
            incident.TheReportedFullTime = dateTimePickercreatedTime.Value;
            incident.IncidentDeadline = dateTimePickerIncidentdeadline.Value;
            incident.Description = txtDescription.Text;
            incident_Service.InsertIncident(incident);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MODEL.Incident incident = new MODEL.Incident();
            incident.SubjectEmail = txtEmail.Text;
            incident.ReportedUser = txtUserID.Text;
            incident.IncidentType = (MODEL.IncidentType)cmbIncidentType.SelectedItem;
            incident.IncidentPriority = (MODEL.IncidentPriority)cmbIncidentPriority.SelectedItem;
            incident.TheReportedFullTime = dateTimePickercreatedTime.Value;
            incident.IncidentDeadline = dateTimePickerIncidentdeadline.Value;
            incident.Description = txtDescription.Text;
            incident_Service.UpdateIncident(incident);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Libmongocrypt;
using System.Windows;
using MODEL;


namespace LOGIC
{
    public class Incident_Service
    {
        private Incident_DAO dao;
        private List<Incident> incidentList;
        public Incident_Service()
        {
            dao = new Incident_DAO();
            //maybe var initilization should be here 
        }
        public List<Incident> GetIncidents()
        {
            return dao.GetIncidents();
        }
        public void UpdateIncident(MODEL.Incident i)
        {
            dao.UpdateIncident(i);
        }
        public void InsertIncident(MODEL.Incident i)
        {
            dao.InsertIncident(i);
        }
        public void RemoveIncident(ObjectId _id)
        {
            dao.RemoveIncident(_id);
        }

        public List<MODEL.Incident> GetIncidentsByEmail(string email)
        {
            return dao.GetIncidentsByEmail(email);
        }

        public List<Incident> PastDeadlineIncidents()
        {
            incidentList = GetIncidents();
            List<Incident> incidents = new List<Incident>();
            for (int i = 0; i < incidentList.Count; i++)
            {
                if (incidents[i].IncidentDeadline < DateTime.Now && incidents[i].Status != Status.Solved)
                {
                    incidents.Add(incidentList[i]);
                }
            }
            return incidents;
        }
        public List<Incident> SortIncidentByStatus(Status status)
        {
            incidentList = GetIncidents();
            List<Incident> incidents = new List<Incident>();
            try
            {
                for (int i = 0; i < incidentList.Count; i++)
                {
                    if (incidentList[i].Status == status)
                    {
                        incidents.Add(incidentList[i]);
                    }
                }
            }
            catch (Exception) { }
            return incidents;
        }
        public List<Incident> GetSolvedIncidents()
        {
            return SortIncidentByStatus(Status.Solved);
        }
        public List<Incident> GetUnsolvedIncidents()
        {
            return PastDeadlineIncidents();
        }
        public List<Incident> GetInProgressIncidents()
        {
            return SortIncidentByStatus(Status.Inprogress);
        }

        //for user management
        public int GetUserIncidents(User user)
        {
            int amount = dao.GetUserIncidents(user);
            return amount;
        }
    }
}

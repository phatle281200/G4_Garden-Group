using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Libmongocrypt;
using MODEL;
using System.Windows;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class Incident_DAO
    {
        private IMongoCollection<Incident> collection;
        public Incident_DAO()
        {
            MongoClient conn = Base.GetInstance();
            IMongoDatabase dbServDesk = conn.GetDatabase("HelpDesk");
            collection = dbServDesk.GetCollection<Incident>("Incident");
        }
        //get  ALl incident fromDB 
        public List<Incident> GetIncidents()
        {
            IFindFluent<Incident, Incident> incidents = GetAllIncidents();
            var results = new List<Incident>();

            foreach (var item in incidents.ToList())
            {
                var incident = new Incident()
                {
                    _id = item._id,
                    SubjectEmail = item.SubjectEmail.ToLower(),
                    IncidentType = (IncidentType)item.IncidentType,
                    IncidentPriority = item.IncidentPriority,
                    Status = item.Status,
                    TheReportedFullTime = item.TheReportedFullTime,
                    IncidentDeadline = item.IncidentDeadline,
                    Description = item.Description.ToLower(),
                    ReportedUser = item.ReportedUser.ToLower(),
                };
                results.Add(incident);
            }
            return results;
        }
        public IFindFluent<Incident, Incident> GetAllIncidents()
        {
            var allIncidents = collection.Find(i => true);
            return allIncidents;
        }
        // this is for the filter
        public List<Incident> GetIncidentsByEmail(string email)
        {
            IFindFluent<Incident, Incident> incidents = GetAllIncidentsByEmail(email);
            var results = new List<Incident>();

            foreach (var item in incidents.ToList())
            {
                var incident = new Incident()
                {
                    _id = item._id,
                    SubjectEmail = item.SubjectEmail.ToLower(),
                    IncidentType = (IncidentType)item.IncidentType,
                    IncidentPriority = item.IncidentPriority,
                    Status = item.Status,
                    TheReportedFullTime = item.TheReportedFullTime,
                    IncidentDeadline = item.IncidentDeadline,
                    Description = item.Description.ToLower(),
                    ReportedUser = item.ReportedUser.ToLower(),
                };
                results.Add(incident);
            }
            return results;
        }
        public IFindFluent<Incident, Incident> GetAllIncidentsByEmail(string email)
        {
            var allIncidents = collection.Find(i => (i.SubjectEmail == email));
            return allIncidents;
        }
        // In this section all the CRUD operation will be defined
        public void InsertIncident(Incident i)
        {
            var IncidentAsJsonDoc = new BsonDocument
            {
                {"ReportedUser", i.ReportedUser.ToLower()},
                {"SubjectEmail", i.SubjectEmail.ToLower()},
                {"IncidentType", i.IncidentType},
                {"IncidentPriority",i.IncidentPriority},
                {"TheReportedFullTime", i.TheReportedFullTime},
                {"IncidentDeadline", i.IncidentDeadline},
                {"Description", i.Description.ToLower()},
                {"Status", i.Status},
            };
            var myObj = BsonSerializer.Deserialize<Incident>(IncidentAsJsonDoc);
            collection.InsertOne(myObj);
        }
        public void RemoveIncident(ObjectId id)
        {
            collection.DeleteOne(a => a._id == id);
        }
        public void UpdateIncident(Incident i)
        {
            var filter = Builders<Incident>.Filter.Eq("_id", i._id);
            var newValue = Builders<Incident>.Update.Set("SubjectEmail", i.SubjectEmail.ToLower()).
                                              Set("IncidentType", i.IncidentType)
                                              .Set("IncidentPriority", i.IncidentPriority)
                                              .Set("TheReportedFullTime", i.TheReportedFullTime)
                                               .Set("IncidentDeadline", i.IncidentDeadline)
                                               .Set("ReportedUser", i.ReportedUser.ToLower())
                                               .Set("Description", i.Description.ToLower())
                                               .Set("Status", i.Status);
            collection.UpdateOne(filter, newValue);
        }

        // this section will be helpful for the statistics
        public int GetUnsolvedIncidents()
        {
            var UnSolvedIncidents = collection.Find(i => (i.Status == Status.Unsolved));
            return (int)UnSolvedIncidents.CountDocuments();
        }
        public int GetSolvedIncidents()
        {
            var SolvedIncidents = collection.Find(i => (i.Status == Status.Solved));
            return (int)SolvedIncidents.CountDocuments();
        }
        public int GetInProgressIncidents()
        {
            var InProgressIncidents = collection.Find(i => (i.Status == Status.Inprogress));
            return (int)InProgressIncidents.CountDocuments();
        }
        //for user management
        public int GetUserIncidents(User user)
        {
            /*
            var incidents = new BsonDocument
            {
                {
                    "$match",
                    new BsonDocument
                    {
                        {"ReportedUser",user.FirstName }
                    }
                }
            };
            var filter = Builders<BsonDocument>.Filter.Eq("ReportedUser", user.FullName);*/
            var userincident = collection.Find(x => x.ReportedUser == user.FullName).ToList();
            return userincident.Count();
        }

    }
}

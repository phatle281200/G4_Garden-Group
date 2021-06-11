using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Libmongocrypt;
using System.Windows;

namespace MODEL
{
    public class Incident
    {
        public MongoDB.Bson.ObjectId _id { get; set; }
        public string SubjectEmail { get; set; }
        public IncidentType IncidentType { get; set; }
        public IncidentPriority IncidentPriority { get; set; }
        public Status Status { get; set; }
        public DateTime TheReportedFullTime { get; set; }
        public DateTime IncidentDeadline { get; set; }
        public string Description { get; set; }
        public string ReportedUser { get; set; }
        public string IncidentOwner { get; set; }
    }
    public enum IncidentType
    {
        Software,
        Hardware,
        Service
    }
    public enum IncidentPriority
    {
        Normal,
        High,
        Low
    }
    public enum Status
    {
        Solved,
        Unsolved,
        Inprogress
    }
}

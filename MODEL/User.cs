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
    public class User //Done by Sam Lo
    {
        public string User_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        //public bool IsAdmin { get; set; } 
        public UserType userType { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string FullName
        {
            get
            {
                string name = FirstName + " " + LastName;
                return name;
            }
        }
        public int IncidentAmount { get; set; }
    }
    public enum UserType
    {
         admin= 0, endUser = 1,
    }
}

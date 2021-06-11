using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class User_DAO //except for the validate method, this was done by Sam Lo
    {
        private IMongoCollection<BsonDocument> userCollection;
        private MongoClient mongoClient;
        private IMongoDatabase mongoDatabase;
        private List<User> users;

        public User_DAO()
        {
            mongoClient = Base.GetInstance(); //get the connection
            mongoDatabase = mongoClient.GetDatabase("HelpDesk"); //get the database
            userCollection = mongoDatabase.GetCollection<BsonDocument>("Users"); //get the collection

            users = new List<User>();
        }
        public List<User> GetAllUsers()
        {
            //foreach document get the user info
            var userDocuments = userCollection.Find(new BsonDocument()).ToList();
            
            foreach (var userDoc in userDocuments)
            {
                users.Add(GetUser(userDoc)); //add the user to the list
            }

            return users;
        }

        public User GetUser(BsonDocument userDoc)
        {
            //get the user
            User user = new User
            {

                User_Id = userDoc.GetValue("_id", new BsonString(string.Empty)).ToString(),
                FirstName = userDoc.GetValue("FirstName", new BsonString(string.Empty)).ToString(),
                LastName=userDoc.GetValue("LastName", new BsonString(string.Empty)).ToString(),
                EmailAddress=userDoc.GetValue("EmailAddress", new BsonString(string.Empty)).ToString(),
                PhoneNumber=userDoc.GetValue("PhoneNumber", new BsonString(string.Empty)).ToString(),
                userType= (UserType)userDoc.GetValue("UserType",new BsonString(string.Empty)).ToInt32()
            };
            
            return user;
        }
        public void CreateUser(User user)
        {
            //create a new document for your user collection using the user info in the parameter.
            var UserBsonDoc = new BsonDocument
                {
                    {"FirstName", user.FirstName },
                    {"LastName", user.LastName },
                    {"EmailAddress", user.EmailAddress },
                    {"PhoneNumber",user.PhoneNumber },
                    {"UserType", user.userType },
                    {"Username", user.Username },
                    {"Password", user.Password }
                };

            userCollection.InsertOne(UserBsonDoc);
          
        }

        public User GetUserByLogin(string username, string password)//for the login but done by Sam
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Username", username);
            filter = filter & Builders<BsonDocument>.Filter.Eq("Password", password);
            var doc = userCollection.Find(filter).First();

            User user = new User
            {

                User_Id = doc.GetValue("_id", new BsonString(string.Empty)).ToString(),
                FirstName = doc.GetValue("FirstName", new BsonString(string.Empty)).ToString(),
                LastName = doc.GetValue("LastName", new BsonString(string.Empty)).ToString(),
                EmailAddress = doc.GetValue("EmailAddress", new BsonString(string.Empty)).ToString(),
                PhoneNumber = doc.GetValue("PhoneNumber", new BsonString(string.Empty)).ToString(),
                userType = (UserType)doc.GetValue("UserType", new BsonString(string.Empty)).ToInt32()
            };

            return user;
        }

        public bool ValidateUser(User user)//Done by Abhishek
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Username",user.Username);
            filter = Builders<BsonDocument>.Filter.Eq("Password", user.Password);
            var loginRecord = userCollection.Find(filter).FirstOrDefault();

            if (loginRecord != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}

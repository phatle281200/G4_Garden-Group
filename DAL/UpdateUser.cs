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
    public class UpdateUser //Sam's individual functionality 
    {
        private IMongoCollection<BsonDocument> userCollection;
        private MongoClient mongoClient;
        private IMongoDatabase mongoDatabase;
        
        public UpdateUser()
        {
            mongoClient = Base.GetInstance();
            mongoDatabase = mongoClient.GetDatabase("HelpDesk");
            userCollection = mongoDatabase.GetCollection<BsonDocument>("Users");

        }

        public void RemoveUser(User user)
        {
            //filter command to get the right user document
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(user.User_Id));
            userCollection.DeleteOne(deleteFilter);
        }


        public void EditUser(User user)
        {
            var updateFilter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(user.User_Id));
            //update command to change the bson document
            var updateUser = Builders<BsonDocument>.Update.
                Set("FirstName", user.FirstName).
                Set("LastName", user.LastName).
                Set("EmailAddress", user.EmailAddress).
                Set("PhoneNumber", user.PhoneNumber).
                Set("UserType", user.userType);

            userCollection.UpdateOne(updateFilter, updateUser);

        }

        public User GetUser(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
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
    }
}

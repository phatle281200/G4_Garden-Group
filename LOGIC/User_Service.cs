using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Libmongocrypt;
using System.Windows;
using MODEL;
using DAL;
using MongoDB.Bson.Serialization.IdGenerators;

namespace LOGIC
{
    public class User_Service //except for the validate method, this was done by Sam Lo
    {
        private User_DAO user_DAO;
        private UpdateUser updateUser;
        private List<User> users;
        public User_Service()
        {
            users = new List<User>();
            user_DAO = new User_DAO();
            updateUser = new UpdateUser();
            
        }
        public List<User> GetAllUsers()
        {
            try
            {
                return users = user_DAO.GetAllUsers(); //gets all users from collection
            }
            catch (Exception)
            {
                User user = new User
                {
                    User_Id = "0",
                    FirstName = "First name",
                    LastName = "Last name",
                    EmailAddress = "123@email.com",
                    PhoneNumber = "0632313123",
                    userType = UserType.admin

                };
                users.Add(user);
                return users;
            }
        }

        public void AddNewUser(User user)
        {
            try
            {
                user_DAO.CreateUser(user);
            }
            catch (Exception)
            {
                User u = new User
                {
                    User_Id = "0",
                    FirstName = "First name",
                    LastName = "Last name",
                    EmailAddress = "123@email.com",
                    PhoneNumber = "0632313123",
                    userType = UserType.admin

                };
                users.Add(u);
            }
        }
        public void AddUsersToDB()//called to add 10 new end users to the collection
        {
            Random random = new Random();
            User[] users = new User[10];
            var letters = "abcdefghijklmnopqrstuvwxyz";
            char[] first = new char[10];
            char[] last = new char[10];
            var numbers = "1234567890";
            char[] charnr = new char[10];

            for (int i = 0; i < users.Length; i++)
            {

                for (int j = 0; j < first.Length; j++)
                {
                    first[j] = letters[random.Next(first.Length)];
                }
                for (int j = 0; j < last.Length; j++)
                {
                    last[j] = letters[random.Next(first.Length)];
                }
                for (int l = 0; l < charnr.Length; l++)
                {
                    charnr[i] = numbers[random.Next(charnr.Length)];
                }


                User u = new User
                {
                    FirstName = new string(first),
                    LastName = new string(last),
                    EmailAddress = new string(first) + "@email.com",
                    PhoneNumber = new string(charnr),
                    Username = "",
                    Password="",
                    userType = UserType.endUser
                    
                };

                user_DAO.CreateUser(u);
            }
            
        }

        
        public User GetUser(string id)
        {
            User user = updateUser.GetUser(id); //Gets the info of the selected user by id
            return user;
        }
        public void EditUser(User user)
        {
            updateUser.EditUser(user);

        }

        public void RemoveUser(User user)
        {
            updateUser.RemoveUser(user);

        }
        public User GetUserByLogin(string username, string password)//Done by Sam because the login did not work properly
        {
            return user_DAO.GetUserByLogin(username,password);
        }

        public bool ValidateUser(User user)//Done by Abhishek
        {
            return user_DAO.ValidateUser(user);
        }
    }
}

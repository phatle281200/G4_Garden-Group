using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Libmongocrypt;
using System.Windows;

namespace DAL
{
    public class Base
    {
        // Apply the singleton pattern 
        private static MongoClient instance = null;

        private Base() { }
        public static MongoClient GetInstance()
        {

            if (instance == null)
            {
                try
                {
                    instance = new MongoClient("mongodb+srv://admin:admin@cluster0.en7n0.azure.mongodb.net/HelpDesk?retryWrites=true&w=majority");
                }
                catch (Exception e)
                {
                    MessageBox.Show("failed to connect to database" + e.ToString());
                }

            }
            return instance;
        }
    }
}

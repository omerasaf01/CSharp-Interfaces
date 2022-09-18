using InterfaceExamples.Interfaces;
using InterfaceExamples.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples.Repository
{
    public class Repository : IDatabase
    {
        public IMongoDatabase Connection()
        {
            var Settings = MongoClientSettings.FromConnectionString("mongodb+srv://<username>:<password>@cluster0.3kwmm.mongodb.net/?retryWrites=true&w=majority");
            Settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var Client = new MongoClient(Settings);
            var Database = Client.GetDatabase("InterfaceExample");

            return Database;
        }

        public bool Delete(int Id, string Collection)
        {
            IMongoCollection<UserModel> db = Connection().GetCollection<UserModel>(Collection);
            db.DeleteOne(x => x.Id == Id);
            return true;
        }
        
        public UserModel Find(int Id, string Collection)
        {
            IMongoCollection<UserModel> db = Connection().GetCollection<UserModel>(Collection);
            var Response = db.Find(x => x.Id == Id).ToList();
            UserModel FindData = new UserModel
            {
                Id = Response[0].Id,
                Name = Response[0].Name,
                Surname = Response[0].Surname,
                Password = Response[0].Password
            };
            return FindData;
        }

        public bool Insert(string Collection, UserModel User)
        {
            IMongoCollection<UserModel> db = Connection().GetCollection<UserModel>(Collection);
            db.InsertOne(User);
            return true;
        }

        public bool Update(int Id, string Collection)
        {
            throw new NotImplementedException();
        }
    }
}

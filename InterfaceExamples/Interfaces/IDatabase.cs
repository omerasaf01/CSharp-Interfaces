using InterfaceExamples.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples.Interfaces
{
    public interface IDatabase
    {
        bool Insert(string Collection, UserModel User);
        bool Update(int Id, string Collection);
        UserModel Find(int Id, string Collection);
        bool Delete(int Id, string Collection);
        IMongoDatabase Connection();
    }
}
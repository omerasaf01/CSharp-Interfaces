using InterfaceExamples;
using InterfaceExamples.Interfaces;
using System.ComponentModel;
using InterfaceExamples.Repository;
using InterfaceExamples.Models;

namespace InterfaceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            IDatabase db = new Repository.Repository();
            UserModel User = new UserModel
            {
                Name = "Ömer Asaf",
                Surname = "Karasu",
                Password = "12345678"
            };
            bool StatuInsert = db.Insert(Collection:"Users", User:User);
            if (StatuInsert == true)
            {
                Console.WriteLine("İşlem Başarılı");
            }
            else
            {
                Console.WriteLine("İşlem Başarısız!");
            }

        }
    }
}
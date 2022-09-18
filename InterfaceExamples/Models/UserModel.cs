using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples.Models
{
    public class UserModel
    {
        [BsonId]
        public ObjectId UserId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public UserModel()
        {
            Id = UserId.Increment;
        }
    }
}

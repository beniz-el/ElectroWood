using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace test
{
    class profs
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Filiere { get; set; }
        public string Email { get; set; }
    }
}

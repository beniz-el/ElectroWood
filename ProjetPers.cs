using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace test
{
    class ProjetPers
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Nom { get; set; }
        public string CIN_prof { get; set; }
        public string Groupe { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace test
{
    class Reservation
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Date_debut { get; set; }
        public string Date_fin { get; set; }
        public string CIN_prof { get; set; }
        public string Groupe { get; set; }
        public string Projet { get; set; }
       
        
    }
}

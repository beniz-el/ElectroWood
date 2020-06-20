using System;
using MongoDB.Bson.Serialization.Attributes;

namespace test
{
    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string pseudo { get; set; }
        public string password { get; set; }
    }
}

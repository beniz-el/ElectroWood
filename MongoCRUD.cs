using MongoDB.Driver;

namespace test
{
    public class MongoCRUD
    {
        private IMongoDatabase db;
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

    }
}

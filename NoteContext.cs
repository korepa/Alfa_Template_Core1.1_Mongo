using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Alfa_Template_Core11_Mongo
{
    public class NoteContext
    {
        private readonly IMongoDatabase _database = null;

        public NoteContext(IOptions<Model.Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Model.Note> Notes
        {
            get
            {
                return _database.GetCollection<Model.Note>("Note");
            }
        }
    }
}

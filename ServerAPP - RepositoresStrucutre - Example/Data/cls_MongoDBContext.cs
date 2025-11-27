using MongoDB.Bson;
using MongoDB.Driver;
using certinom_sadper_v1.Modelos.Settings;

namespace certinom_sadper_v1.Data
{
    public class cls_MongoDBContext
    {
        #region Properties
        private IMongoClient _client { get; set; } = null!;
        private IMongoDatabase _database { get; set; } = null!;
        private mdl_MongoDBSettings _settings { get; set; }
        #endregion

        public cls_MongoDBContext(mdl_MongoDBSettings settings)
        {
            _settings = settings;
            string sDatabase = _settings.sDatabase;
            string sMongoStringConnection = ConstruirMongoConnection();
            
            if (!string.IsNullOrEmpty(sMongoStringConnection))
            {
                if(!string.IsNullOrEmpty(sDatabase))
                {
                    _client = new MongoClient(sMongoStringConnection);
                    _database = _client.GetDatabase(sDatabase)
                        ?? throw new Exception($"No se pudo conectar a la base de datos '{sDatabase}'.");
                }
                else
                    _client = new MongoClient(sMongoStringConnection);
            }
        }


        #region String Connection
        private string ConstruirMongoConnection()
        {
            string sconnection = $"mongodb://{_settings.sUsuarioPrt}:{_settings.sPassPrt}@{_settings.sHost}:{_settings.sPort}/?authSource=admin";
            return sconnection;
        }

        #endregion
        static bool VerificarColeccion(IMongoDatabase database, string sCollection)
        {
            var filter = new BsonDocument("name", sCollection);
            using (var collections = database.ListCollectionNames(new ListCollectionNamesOptions { Filter = filter }))
            {
                return collections.Any();
            }
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            if (!VerificarColeccion(_database, collectionName))
            {
                Console.WriteLine($"La coleccion {collectionName} no existe, sera creada a continuacion.");
                _database.CreateCollection(collectionName);
            }
            return _database.GetCollection<T>(collectionName)
                ?? throw new Exception($"No se pudo obtener la colección '{collectionName}' de la base de datos '{_database.DatabaseNamespace.DatabaseName}'.");
        }

        public IMongoCollection<BsonDocument> GetBsonCollection(string collectionName)
        {
            if (!VerificarColeccion(_database, collectionName))
            {
                Console.WriteLine($"La coleccion {collectionName} no existe, sera creada a continuacion.");
                _database.CreateCollection(collectionName);
            }

            return _database.GetCollection<BsonDocument>(collectionName)
                ?? throw new Exception($"No se pudo obtener la colección '{collectionName}' de la base de datos '{_database.DatabaseNamespace.DatabaseName}'.");
        }

    }
}

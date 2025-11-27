using MongoDB.Driver;
using System.Linq.Expressions;
using certinom_sadper_v1.Data.Repositories.Interfaces;
using certinom_sadper_v1.Data.Factories;

namespace certinom_sadper_v1.Data.Services
{
    public class RepositoryService<T> : IRepositoryService<T> where T : class
    {

        private readonly IMongoDBContextFactory? _contextFactory;
        private readonly string _collectionName;

        // El constructor solo guarda las dependencias. NO se conecta a la DB.
        public RepositoryService( IMongoDBContextFactory contextFactory, string collectionName)
        {
            _collectionName = collectionName;

            if (contextFactory != null)
                _contextFactory = contextFactory;


        }


        public IMongoCollection<T> GetCollection()
        {
            var context = default(cls_MongoDBContext);
            try
            {
                if (_contextFactory != null)
                {
                    context = _contextFactory.GetContext();
                
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                "No se puede acceder a la base de datos. " +
                $"Asegúrese de haber iniciado sesión primero. \n{ex.Message}");
                
            }

            return context.GetCollection<T>(_collectionName);

        }


        public virtual async Task<bool> UpdateOneAsync(FilterDefinition<T> filter, UpdateDefinition<T> update)
        {
            var _collection = GetCollection();
            var result = await _collection.UpdateOneAsync(filter, update);
            return result.ModifiedCount > 0;
        }

        public async Task<List<T>> GetAllAsync()
        {

            var _collection = GetCollection();
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {

            var _collection = GetCollection();
            var filter = Builders<T>.Filter.Eq("_id", id);
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<T> GetByRFC(string sRFC)
        {

            var _collection = GetCollection();
            var filter = Builders<T>.Filter.Eq("co_rfc", sRFC);
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }

        public virtual async Task CreateAsync(T entity)
        {
            var _collection = GetCollection();
            await _collection.InsertOneAsync(entity);
        }

        public virtual async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            var _collection = GetCollection();
            return await _collection.Find(predicate).ToListAsync();
        }



        public virtual async Task<long> UpdateManyAsync(FilterDefinition<T> filter, UpdateDefinition<T> update)
        {
            var _collection = GetCollection();
            var result = await _collection.UpdateManyAsync(filter, update);
            return result.ModifiedCount;
        }

        public virtual async Task ReplaceOneAsync(string id, T entity)
        {
            var _collection = GetCollection();
            await _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", id), entity);
        }

        public virtual async Task DeleteAsync(string id)
        {
            var _collection = GetCollection();
            await _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", id));
        }
    }
}

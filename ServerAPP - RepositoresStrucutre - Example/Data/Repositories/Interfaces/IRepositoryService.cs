using MongoDB.Driver;
using System.Linq.Expressions;

namespace certinom_sadper_v1.Data.Repositories.Interfaces
{
    public interface IRepositoryService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);

        Task<T> GetByRFC(string value);

        Task CreateAsync(T entity);
        Task<List<T>> FindAsync(Expression<Func<T, bool>> filter);
      
        Task<bool> UpdateOneAsync(FilterDefinition<T> filter, UpdateDefinition<T> update);

        Task<long> UpdateManyAsync(FilterDefinition<T> filter, UpdateDefinition<T> update);

        Task ReplaceOneAsync(string id, T oEntidad);
        Task DeleteAsync(string id);

      
    }
}

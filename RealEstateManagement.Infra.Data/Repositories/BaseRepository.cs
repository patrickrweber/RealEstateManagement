using RealEstateManagement.Domain.Interfaces.Repositories;
using RealEstateManagement.Infra.Data.Data;

namespace RealEstateManagement.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly MySqlContext _sqlContext;
        public BaseRepository(MySqlContext context)
        {
            _sqlContext = context;
        }

        public IQueryable<T> GetAll()
        {
            return _sqlContext.Set<T>();
        }

        public async Task<T> GetById(int id)
        {
            return await _sqlContext.Set<T>().FindAsync(id);
        }

        public Task<int> Save(T entity)
        {
            _sqlContext.Set<T>().Add(entity);
            return _sqlContext.SaveChangesAsync();
        }

        public Task<int> Update(T entity)
        {
            _sqlContext.Set<T>().Update(entity);
            return _sqlContext.SaveChangesAsync();
        }
        public Task<int> Delete(T entity)
        {
            _sqlContext.Set<T>().Remove(entity);
            return _sqlContext.SaveChangesAsync();
        }
    }
}

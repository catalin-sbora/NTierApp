using Microsoft.EntityFrameworkCore;
using NTierApp.DataAccess.Abstractions;
using NTierApp.DataAccess.Model;

namespace NTierApp.DataAccess.EF
{
    public class BaseRepository<T> : IBaseRepository<T> where T : ModelEntity
    {
        protected readonly DbContext dbContext;
        public BaseRepository(DbContext dbContext) 
        { 
            this.dbContext = dbContext;
        }
        public T Add(T entity)
        {
            var added = dbContext.Set<T>().Add(entity);            
            dbContext.SaveChanges();
            return added.Entity;
        }        

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>()
                            .ToList();
        }

        public void Remove(int entityId)
        {
            var element = dbContext.Set<T>()
                                   .First(e => e.Id == entityId);
            dbContext.Remove(element);
            dbContext.SaveChanges();
        }
    }
}
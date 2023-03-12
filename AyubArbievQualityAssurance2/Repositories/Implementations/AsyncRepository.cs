using AyubArbievQualityAssurance2.Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using QualityAssurance2.Data.DataBase.SqlServer;
using QualityAssurance2.Data.Repositories.Interfaces;

namespace QualityAssurance2.Data.Repositories.Implementations
{
    public class AsyncRepository<T> : IExist,IAsyncRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _contextDb;

        public AsyncRepository(AppDbContext context)
        {
            _contextDb = context;
        }


        public async Task Create(T item)
        {
            if (DataBaseExist()) return;
            await _contextDb.Set<T>().AddAsync(item);
            await _contextDb.SaveChangesAsync();
        }
        public IQueryable<T> Get()
        {
            if (DataBaseExist()) return default(IQueryable<T>);
            return _contextDb.Set<T>();
        }
        public async Task Update(T Item)
        {
            if (DataBaseExist()) return;
            _contextDb.Set<T>().Update(Item);
            await _contextDb.SaveChangesAsync();
        }
        public async Task Delete(T item)
        {
            if (DataBaseExist()) return;
            _contextDb.Set<T>().Remove(item);
            await _contextDb.SaveChangesAsync();
        }
        public bool DataBaseExist()
        {
            DbSet<T> TestSet = _contextDb.Set<T>();
            if (TestSet == default(DbSet<T>))
                return true;
            return false;
        }

    }
}

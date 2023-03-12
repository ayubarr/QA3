using AyubArbievQualityAssurance2.Data.Models.Common;

namespace QualityAssurance2.Data.Repositories.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        public Task Create(T item);        // C - Create
        public IQueryable<T> Get();        // R - Read
        public Task Update(T Item);     // U - Update
        public Task Delete(T item);     // D - Delete
    }
}

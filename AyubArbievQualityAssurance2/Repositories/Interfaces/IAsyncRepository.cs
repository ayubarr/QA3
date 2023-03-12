using AyubArbievQualityAssurance2.Data.Models.Common;

namespace QualityAssurance2.Data.Repositories.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        public T Add(T item);        // C - Create
        public List<T> GetAll();     // R - ReadAll
        public T GetById(int id);    // R - ReadOne
        public IQueryable<T> Get();  // R - Read
        public void Update(T Item);  // U - Update
        public void Delete(T item);  // D - Delete
    }
}

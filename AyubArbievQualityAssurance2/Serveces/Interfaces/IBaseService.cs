using AyubArbievQualityAssurance2.Data.Models.Common;
using QualityAssurance2.Data.Serveces.Response;

namespace QualityAssurance2.Data.Serveces.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        IBaseResponse<T> Create(T model);       
        IBaseResponse<List<T>> Get();
        IBaseResponse<T> GetById(int id);
        IBaseResponse<T> Update(T model);
        IBaseResponse<bool> Delete(int id);

    }
}

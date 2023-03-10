using AyubArbievQualityAssurance2.Data.Models.Common;
using QualityAssurance2.Data.Serveces.Implementations.Response;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;

namespace QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces
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

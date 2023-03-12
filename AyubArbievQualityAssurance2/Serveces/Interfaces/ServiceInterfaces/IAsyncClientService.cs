using AyubArbievQualityAssurance2.Data.Models.Entities;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;

namespace QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces
{
    public interface IAsyncClientService
    {
        Task<IBaseResponse<Client>> Create(Client model);
        IBaseResponse<List<Client>> Get();
        Task<IBaseResponse<Client>> GetById(int id);
        Task<IBaseResponse<Client>> Update(Client model);
        Task<IBaseResponse<bool>> Delete(int id);
    }
}

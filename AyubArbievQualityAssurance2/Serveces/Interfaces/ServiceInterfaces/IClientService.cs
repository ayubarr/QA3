using AyubArbievQualityAssurance2.Data.Models.Entities;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;

namespace QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces
{
    public interface IClientService
    {
        IBaseResponse<Client> Create(Client model);
        IBaseResponse<List<Client>> Get();
        IBaseResponse<Client> GetById(int id);
        IBaseResponse<Client> Update(Client model);
        IBaseResponse<bool> Delete(int id);
    }
}

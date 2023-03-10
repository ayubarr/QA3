using AyubArbievQualityAssurance2.Data.Models.Entities;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;

namespace QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces
{
    public interface IOrderService
    {
        IBaseResponse<Order> Create(Order model);
        IBaseResponse<List<Order>> Get();
        IBaseResponse<Order> GetById(int id);
        IBaseResponse<Order> Update(Order model);
        IBaseResponse<bool> Delete(int id);
    }
}

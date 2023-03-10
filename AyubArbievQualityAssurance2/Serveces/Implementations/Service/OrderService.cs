using AyubArbievQualityAssurance2.Data.Models.Entities;
using QualityAssurance2.Data.Repositories.Implementations;
using QualityAssurance2.Data.Repositories.Interfaces;
using QualityAssurance2.Data.Serveces.Implementations.Response;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;
using QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces;

namespace QualityAssurance2.Data.Serveces.Implementations.Service
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _repository;
        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }
        public IBaseResponse<Order> Create(Order model)
        {
            try
            {
                _repository.Add(model);
                return new BaseResponse<Order>()
                {
                    Data = model
                };
            }
            catch (Exception e)
            {
                return new BaseResponse<Order>() { Description = e.Message };
            }
        }

        public IBaseResponse<bool> Delete(int id)
        {
            try
            {
                var entity = _repository.Get().FirstOrDefault(x => x.Id == id);
                if (entity == null) return new BaseResponse<bool>() { Description = "User not found" };
                _repository.Delete(entity);
                return new BaseResponse<bool>() { Data = true };
            }
            catch (Exception e)
            {
                return new BaseResponse<bool>() { Description = e.Message };
            }
        }

        public IBaseResponse<List<Order>> Get()
        {
            try
            {
                var entity = _repository.Get().ToList();
                if (!entity.Any()) return new BaseResponse<List<Order>>() { Description = "Elements not found" };
                return new BaseResponse<List<Order>>() { Data = entity };
            }
            catch (Exception e)
            {

                return new BaseResponse<List<Order>>() { Description = e.Message };
            }
        }

        public IBaseResponse<Order> GetById(int id)
        {
            try
            {
                var entity = _repository.Get().FirstOrDefault(x => x.Id == id);
                if (entity == null) return new BaseResponse<Order>() { Description = "User not found" };
                return new BaseResponse<Order>() { Data = entity };


            }
            catch (Exception e)
            {
                return new BaseResponse<Order>() { Description = e.Message };
            }
        }

        public IBaseResponse<Order> Update(Order model)
        {
            try
            {
                var entity = _repository.Get().FirstOrDefault(x => x.Id == model.Id);
                Order _order = entity as Order;
                Order _model = model as Order;
                _order.OrderPrice = _model.OrderPrice;
                _order.OrderDate = _model.OrderDate;
                _order.ClientId = _model.ClientId;
                _order.CloseDate = _model.CloseDate;
                _order.Description = _model.Description;

                _repository.Update(entity);
                return new BaseResponse<Order>() { Data = entity };
            }
            catch (Exception e)
            {
                return new BaseResponse<Order>() { Description = e.Message };
            }
        }
    }
}

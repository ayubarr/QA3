using AyubArbievQualityAssurance2.Data.Models.Common;
using AyubArbievQualityAssurance2.Data.Models.Entities;
using QualityAssurance2.Data.Repositories.Implementations;
using QualityAssurance2.Data.Repositories.Interfaces;
using QualityAssurance2.Data.Serveces.Implementations.Response;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;
using QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces;

namespace QualityAssurance2.Data.Serveces.Implementations.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;
        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public IBaseResponse<T> Create(T model)
        {
            try
            {
                _repository.Add(model);
                return new BaseResponse<T>()
                {
                    Data = model
                };
            }
            catch (Exception e)
            {
                return new BaseResponse<T>() { Description = e.Message };
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

        public IBaseResponse<List<T>> Get()
        {
            try
            {
                var entity = _repository.Get().ToList();
                if (!entity.Any()) return new BaseResponse<List<T>>() { Description = "Elements not found" };
                return new BaseResponse<List<T>>() { Data = entity };
            }
            catch (Exception e)
            {

                return new BaseResponse<List<T>>() { Description = e.Message };
            }
        }

        public IBaseResponse<T> GetById(int id)
        {
            try
            {
                var entity = _repository.Get().FirstOrDefault(x => x.Id == id);
                if (entity == null) return new BaseResponse<T>() { Description = "User not found" };
                return new BaseResponse<T>() { Data = entity };


            }
            catch (Exception e)
            {
                return new BaseResponse<T>() { Description = e.Message };
            }
        }

        public IBaseResponse<T> Update(T model)
        {

            try
            {
                var entity = _repository.Get().FirstOrDefault(x => x.Id == model.Id);
                if (entity == null) return new BaseResponse<T>() { Description = "User not found" };

                if (typeof(T) == typeof(Client))
                {
                    Client _client = entity as Client;
                    Client _model = model as Client;
                    _client.FirstName = _model.FirstName;
                    _client.LastName = _model.LastName;
                    _client.PhoneNum = _model.PhoneNum;
                    _client.DateAdd = _model.DateAdd;
                    _client.OrderAmount = _model.OrderAmount;
                }
                if (typeof(T) == typeof(Order))
                {
                    Order _order = entity as Order;
                    Order _model = model as Order;
                    _order.OrderPrice = _model.OrderPrice;
                    _order.OrderDate = _model.OrderDate;
                    _order.ClientId = _model.ClientId;
                    _order.CloseDate = _model.CloseDate;
                    _order.Description = _model.Description;
                }

                _repository.Update(entity);
                return new BaseResponse<T>() { Data = entity };
            }
            catch (Exception e)
            {
                return new BaseResponse<T>() { Description = e.Message };
            }
        }
    }

}

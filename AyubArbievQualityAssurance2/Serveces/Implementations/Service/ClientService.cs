using AyubArbievQualityAssurance2.Data.Models.Entities;
using QualityAssurance2.Data.Repositories.Implementations;
using QualityAssurance2.Data.Repositories.Interfaces;
using QualityAssurance2.Data.Serveces.Implementations.Response;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;
using QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces;

namespace QualityAssurance2.Data.Serveces.Implementations.Service
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> _repository;
        public ClientService(IRepository<Client> repository)
        {
            _repository = repository;
        }
        public IBaseResponse<Client> Create(Client model)
        {
            try
            {
                _repository.Add(model);
                return new BaseResponse<Client>()
                {
                    Data = model
                };
            }
            catch (Exception e)
            {
                return new BaseResponse<Client>() { Description = e.Message };
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

        public IBaseResponse<List<Client>> Get()
        {
            try
            {
                var entity = _repository.Get().ToList();
                if (!entity.Any()) return new BaseResponse<List<Client>>() { Description = "Elements not found" };
                return new BaseResponse<List<Client>>() { Data = entity };
            }
            catch (Exception e)
            {

                return new BaseResponse<List<Client>>() { Description = e.Message };
            }
        }

        public IBaseResponse<Client> GetById(int id)
        {
            try
            {
                var entity = _repository.Get().FirstOrDefault(x => x.Id == id);
                if (entity == null) return new BaseResponse<Client>() { Description = "User not found" };
                return new BaseResponse<Client>() { Data = entity };


            }
            catch (Exception e)
            {
                return new BaseResponse<Client>() { Description = e.Message };
            }
        }

        public IBaseResponse<Client> Update(Client model)
        {
            try
            {
                var entity = _repository.Get().FirstOrDefault(x => x.Id == model.Id);
                Client _client = entity as Client;
                Client _model = model as Client;
                _client.FirstName = _model.FirstName;
                _client.LastName = _model.LastName;
                _client.PhoneNum = _model.PhoneNum;
                _client.DateAdd = _model.DateAdd;
                _client.OrderAmount = _model.OrderAmount;
                _repository.Update(entity);
                return new BaseResponse<Client>() { Data = entity };
            }
            catch (Exception e)
            {
                return new BaseResponse<Client>() { Description = e.Message };
            }
        }
    }
}

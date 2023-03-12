using AyubArbievQualityAssurance2.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using QualityAssurance2.Data.Repositories.Interfaces;
using QualityAssurance2.Data.Serveces.Implementations.Response;
using QualityAssurance2.Data.Serveces.Interfaces.ResponseInterfaces;
using QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces;

namespace QualityAssurance2.Data.Serveces.Implementations.Service
{
    public class AsyncClientService : IAsyncClientService
    {
        private readonly IAsyncRepository<Client> _repository;
        public AsyncClientService(IAsyncRepository<Client> repository)
        {
            _repository = repository;
        }
        public async Task<IBaseResponse<Client>> Create(Client model)
        {
            try
            {
                await _repository.Create(model);
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

        public async Task<IBaseResponse<bool>> Delete(int id)
        {
            try
            {
                var entity = await _repository.Get().FirstOrDefaultAsync(x => x.Id == id);                     //await
                if (entity == null) return new BaseResponse<bool>() { Description = "User not found" };
                await _repository.Delete(entity);                                                              //await
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
                var entity = _repository.Get().ToList();                                                        //NO AWAIT 
                if (!entity.Any()) return new BaseResponse<List<Client>>() { Description = "Elements not found" };
                return new BaseResponse<List<Client>>() { Data = entity };
            }
            catch (Exception e)
            {

                return new BaseResponse<List<Client>>() { Description = e.Message };
            }
        }

        public async Task<IBaseResponse<Client>> GetById(int id)
        {
            try
            {
                var entity = await _repository.Get().FirstOrDefaultAsync(x => x.Id == id);                  //await
                if (entity == null) return new BaseResponse<Client>() { Description = "User not found" };
                return new BaseResponse<Client>() { Data = entity };


            }
            catch (Exception e)
            {
                return new BaseResponse<Client>() { Description = e.Message };
            }
        }

        public async Task<IBaseResponse<Client>> Update(Client model)
        {
            try
            {
                var entity = await _repository.Get().FirstOrDefaultAsync(x => x.Id == model.Id);                //await
                Client _client = entity as Client;
                Client _model = model as Client;
                _client.FirstName = _model.FirstName;
                _client.LastName = _model.LastName;
                _client.PhoneNum = _model.PhoneNum;
                _client.DateAdd = _model.DateAdd;
                _client.OrderAmount = _model.OrderAmount;
                await _repository.Update(entity);                                                               //await
                return new BaseResponse<Client>() { Data = entity };
            }
            catch (Exception e)
            {
                return new BaseResponse<Client>() { Description = e.Message };
            }
        }
    }
}

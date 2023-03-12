using AyubArbievQualityAssurance2.Data.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using QualityAssurance2.Data.Serveces.Interfaces.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QualityAssurance2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IAsyncClientService _services;

        public ClientController(IAsyncClientService services)
        {
            _services = services;
        }


        // GET: api/<ClientController>
        [HttpGet]
        public IResult Get()
        {
            var response = _services.Get();
            return Results.Ok(response.Data);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            var response = await _services.GetById(id);
            return Results.Ok(response.Data);
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task Post(Client model)
        {
            await _services.Create(model);

        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, Client model)  // Update
        {
            await _services.Update(model);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _services.Delete(id);
        }
    }
}

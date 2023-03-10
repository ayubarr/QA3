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
        private readonly IClientService _services;

        public ClientController(IClientService services)
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
        public IResult Get(int id)
        {
            var response = _services.GetById(id);
            return Results.Ok(response.Data);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post(Client model )
        {
            _services.Create(model);

        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, Client model)  // Update
        {
            _services.Update(model);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _services.Delete(id);
        }
    }
}

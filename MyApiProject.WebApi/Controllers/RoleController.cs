using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiProject.Mock;
using MyApiProject.Repositories.Entities;
using MyApiProject.Repositories.Interfaces;
using MyApiProject.Repositories.Repositories;

namespace MyApiProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        public RoleController()
        {
            var mock = new MockContext();
            _roleRepository = new RoleRepository(mock);
        }

        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }


        [HttpGet("{id}")]
        public Role GetById(int Id)
        {
            return _roleRepository.GetById(Id);
        }

        //int Id, string Name, string Description

        [HttpPost]
        public void insert(Role role)
        {
            _roleRepository.Add(role) ; 
        }
        
        [HttpPut("{id}")]
        public bool Update(int id, Role Role)
        {
            return _roleRepository.Update(id,Role);
        }

        [HttpDelete("{id}")]
        public void delete(int id)
        {
            _roleRepository.Delete(id);
        }



        /* private static readonly string[] Summaries = new[]
         {
         "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
     };

         private readonly ILogger<RoleController> _logger;

         public RoleController(ILogger<RoleController> logger)
         {
             _logger = logger;
         }

         [HttpGet(Name = "GetWeatherForecast")]
         public IEnumerable<WeatherForecast> Get()
         {
             return Enumerable.Range(1, 5).Select(index => new WeatherForecast
             {
                 Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                 TemperatureC = Random.Shared.Next(-20, 55),
                 Summary = Summaries[Random.Shared.Next(Summaries.Length)]
             })
             .ToArray();
         }*/
    }
}
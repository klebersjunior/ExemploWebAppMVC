using Microsoft.AspNetCore.Mvc;
using ExemploWebAPI.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using ExemploWebAPI.Model;

namespace ExemploWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarCRUDController : ControllerBase
    {
        private readonly CarDBContext _context;
        private readonly IConfiguration _configuration;


        public CarCRUDController(CarDBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public List<CarModel> GetAll()
        {
            //CarDBContext carDBContext = new CarDBContext(_configuration.GetConnectionString("CarDatabase"));

            return _context.Cars.ToList();
        }
    }

}

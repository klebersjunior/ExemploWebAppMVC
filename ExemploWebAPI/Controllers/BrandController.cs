using ExemploWebAPI.Context;
using ExemploWebAPI.Model;
using ExemploWebAPI.Model.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ExemploWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly CarDBContext _context;

        public BrandController(CarDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand([FromBody] BrandRequest request)
        {
            var newBrand = new BrandModel { Name = request.Name };

            _context.Brand.Add(newBrand);
            await _context.SaveChangesAsync();

            return Ok(newBrand);
        }
    }
}

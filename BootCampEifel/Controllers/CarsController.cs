using Microsoft.AspNetCore.Mvc;
using BootCampEifel.DataAccess.Entities;
using BootCampEifel.DataAccess.Repositories;

namespace BootCampEifel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        readonly ICarsRepository _carros;

        public CarsController(ICarsRepository carros)
        {
            _carros = carros;
        }

        [HttpGet(Name = "GetCar")]
        public async Task<Cars> Get(int CarId)
        {
            return await _carros.GetCarById(CarId);
        }


        [HttpPost(Name = "CreateCar")]
        public async Task<Cars> Get([FromBody] Cars MyCar)
        {
            return await _carros.CreateCar(MyCar);
        }
    }
}

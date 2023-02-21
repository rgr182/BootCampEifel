using Microsoft.AspNetCore.Mvc;
using BootCampEifel.Utils;

namespace BootCampEifel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        readonly List<Cars> _carros;

        public CarsController()
        {
            _carros = new List<Cars>
            {
                new Cars
                {
                    Motor = "V8",
                    Speed = "200km/h",
                    Brand = "Toyota",
                    Year = 2023,
                    Color = "Red"
                },

                new Cars
                {
                    Motor = "V6",
                    Speed = "180km/h",
                    Brand = "Mazda",
                    Year = 2020,
                    Color = "Blue"
                },

                new Cars
                {
                    Motor = "V4",
                    Speed = "150km/h",
                    Brand = "Mercedes Benz",
                    Year = 2015,
                    Color = "White"
                }
             };
        }

        [HttpGet(Name = "GetCar")]
        public List<Cars> Get()
        {
            return _carros;
        }
    }
}

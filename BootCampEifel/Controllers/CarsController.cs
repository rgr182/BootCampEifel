using Microsoft.AspNetCore.Mvc;
using BootCampEifel.Utils;
using Microsoft.AspNetCore.Http;

namespace BootCampEifel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        readonly Cars _carros;

        public CarsController ()
        {
            _carros = new Cars();
        }       

        [HttpGet(Name = "GetCar")]
        public List<string> Get(char search)
        {
            List<string> llantas = new List<string>();
            llantas.Add(_carros.Llanta("rojo", 12));
            llantas.Add(_carros.Llanta("verde", 15));
            llantas.Add(_carros.Llanta("amarillo", 17));
            llantas.Add(_carros.Llanta("negro", 20));
            var result = llantas.Where(x => x.Contains(search)).ToList();
            return result;
        }
    }
}

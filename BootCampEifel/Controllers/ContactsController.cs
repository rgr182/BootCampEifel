using Microsoft.AspNetCore.Mvc;
using BootCampEifel.DataAccess.Entities;
using BootCampEifel.DataAccess.Repositories;

namespace BootCampEifel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        readonly IContactsRepository _carros;

        public ContactsController(IContactsRepository carros)
        {
            _carros = carros;
        }

        [HttpGet(Name = "GetContact")]
        public async Task<Contact> Get(int CarId)
        {
            return await _carros.GetContactById(CarId);
        }


        [HttpPost(Name = "CreateContact")]
        public async Task<Contact> Get([FromBody] Contact contact)
        {
            return await _carros.CreateContact(contact);
        }
    }
}

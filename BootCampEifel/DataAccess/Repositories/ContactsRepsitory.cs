using BootCampEifel.DataAccess.Context;
using BootCampEifel.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BootCampEifel.DataAccess.Repositories
{
    public class ContactsRepsitory : IContactsRepository
    {
        internal SchoolSystemContext _context;

        public ContactsRepsitory(SchoolSystemContext context)
        {
            _context = context;
        }


        public async Task<Contact> CreateContact(Contact contact)
        {
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
            return contact;
        }



        public async Task<Contact> GetContactById(int contactId)
        {
            var response = await _context.Contacts.Where(c => c.ContactId == contactId)
                .FirstOrDefaultAsync();

            return response;
        }


        public async Task<Contact> GetContactByEmail(string Email)
        {
            var response = await _context.Contacts.Where(c => c.Email == Email)
                .FirstOrDefaultAsync();

            return response;
        }
    }

    public interface IContactsRepository
    {
        public Task<Contact> GetContactById(int contactId);

        public Task<Contact> GetContactByEmail(string email);

        public Task<Contact> CreateContact(Contact contact);
    }
}


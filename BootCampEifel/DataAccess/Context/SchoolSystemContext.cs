using BootCampEifel.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BootCampEifel.DataAccess.Context
{
    public class SchoolSystemContext : DbContext
    {
        public SchoolSystemContext()
        {
        }

        public SchoolSystemContext(DbContextOptions<SchoolSystemContext> options)
          : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

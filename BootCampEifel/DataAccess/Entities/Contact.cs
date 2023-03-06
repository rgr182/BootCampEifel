using System.ComponentModel.DataAnnotations;

namespace BootCampEifel.DataAccess.Entities
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }   
        
        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}

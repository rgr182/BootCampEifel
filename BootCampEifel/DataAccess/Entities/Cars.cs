using System.ComponentModel.DataAnnotations;

namespace BootCampEifel.DataAccess.Entities
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }
        public string Motor { get; set; }
        public string Speed { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }      
    }
}

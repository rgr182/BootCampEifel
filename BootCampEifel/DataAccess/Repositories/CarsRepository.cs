using BootCampEifel.DataAccess.Context;
using BootCampEifel.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BootCampEifel.DataAccess.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        internal SchoolSystemContext _context;

        public CarsRepository(SchoolSystemContext context)
        {
            _context = context;
        }


        public async Task<Cars> CreateCar(Cars carr) {
            await _context.Cars.AddAsync(carr);
            await _context.SaveChangesAsync();            
            return carr;
        }



        public async Task<Cars> GetCarById(int CarId)
        {
            var response = await _context.Cars.Where(c => c.CarId == CarId)
                .FirstOrDefaultAsync();

            return response;
        }
    }

    public interface ICarsRepository { 
    
       public Task<Cars> GetCarById(int CarId);

        public Task<Cars> CreateCar(Cars carr);
    }
}


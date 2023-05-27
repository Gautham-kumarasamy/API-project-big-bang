using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace final333.MODEL
{
    public class userRepository : IHotelRepository
    {
        private readonly Hoteldbcontext _dbContext;

        public userRepository(Hoteldbcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Hotel>> GetAllHotels()
        {
            return await _dbContext.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetHotelById(int hotelId)
        {
            return await _dbContext.Hotels.FirstOrDefaultAsync(h => h.hotelid == hotelId);
        }

        public async Task AddHotel(Hotel hotel)
        {
            _dbContext.Hotels.Add(hotel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            _dbContext.Entry(hotel).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteHotel(int hotelId)
        {
            var hotel = await _dbContext.Hotels.FindAsync(hotelId);
            if (hotel != null)
            {
                _dbContext.Hotels.Remove(hotel);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}

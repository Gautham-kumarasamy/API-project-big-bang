using System.Collections.Generic;
using System.Threading.Tasks;

namespace final333.MODEL
{
    public interface userInterfaceRepository
    {
        Task<IEnumerable<Hotel>> GetAllHotels();
        Task<Hotel> GetHotelById(int hotelId);
        Task AddHotel(Hotel hotel);
        Task UpdateHotel(Hotel hotel);
        Task DeleteHotel(int hotelId);
    }
}
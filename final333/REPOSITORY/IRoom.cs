using final333.MODEL;
using Microsoft.AspNetCore.Mvc;

namespace final333.REPOSITORY
{
    public interface IRoom
    {
        Task<ActionResult<IEnumerable<Rooms>>> GetRooms();
        Task<ActionResult<Rooms>> GetRooms(int id);
        Task<ActionResult<object>> PostRooms(Rooms rooms);
        Task<string> DeleteRooms(int id);
        Task<ActionResult<List<Rooms>>> RoomsAvail();
        Task<ActionResult<Object>> TotalRooms();
        Task<ActionResult<object>> AmenitiesSearch(Rooms room);
    }
}

using final333.MODEL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace final333.REPOSITORY
{
    public class Room : IRoom
    {
        private readonly Hoteldbcontext _context;
        public Room(Hoteldbcontext context )
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Rooms>>> GetRooms()
        {
            var room = await _context.Rooms.ToListAsync();
            return room;
        }

        public async Task<ActionResult<Rooms>> GetRooms(int id)
        {
            var room=await _context.Rooms.FirstOrDefaultAsync(x=>x.roomid==id);
            return room;
        }

        public async Task<ActionResult<object>> PostRooms(Rooms rooms)
        {
           var room= _context.Add(rooms);
           _context.SaveChanges();
            return room;
        }

        public async Task<string> DeleteRooms(int id)
        {
            var room=await _context.Rooms.FirstOrDefaultAsync(x=>x.roomid==id);
            _context.Remove(room);
            _context.SaveChanges();
            return "Deleted";
        }

        public async Task<ActionResult<List<Rooms>>> RoomsAvail()
        {
            var room = await _context.Rooms.Where(x => x.availability == "Yes").ToListAsync();
            return room;
        }

        public async Task<ActionResult<Object>> TotalRooms()
        {
            var room =  _context.Rooms.Count();
            return room;
        }

        public async Task<ActionResult<object>> AmenitiesSearch(Rooms room)
        {
            var r =  _context.Rooms.Where(x => x.location=="Normal");
            return r.ToListAsync();
        }
    }
}

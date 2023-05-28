using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using final333.MODEL;
using final333.REPOSITORY;

namespace final333.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoom _context;

        public RoomsController(IRoom context)
        {
            _context = context;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rooms>>> GetRooms()
        {
            return await _context.GetRooms();
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rooms>> GetRooms(int id)
        {
            return await _context.GetRooms(id);
        }



        // PUT: api/Rooms/5
       

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<object>> PostRooms(Rooms rooms)
        {
            return await _context.PostRooms(rooms);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteRooms(int id)
        {
            return await _context.DeleteRooms(id);

        }

        [HttpGet]
        public async Task<ActionResult<List<Rooms>>> RoomsAvail()
        {
            return await _context.RoomsAvail();
        }

        [HttpGet]
        public async Task<ActionResult<Object>> TotalRooms()
        {
            return await _context.TotalRooms();
        }

        [HttpGet]
        public async Task<ActionResult<object>> AmenitiesSearch(Rooms room)
        {
            return await _context.AmenitiesSearch(room);
        }
        
    }
}

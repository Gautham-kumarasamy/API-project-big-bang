using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace final333.MODEL
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelController(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        // GET: api/Hotel
        [HttpGet]
        public async Task<IActionResult> GetAllHotels()
        {
            try
            {
                var hotels = await _hotelRepository.GetAllHotels();
                return Ok(hotels);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/Hotel/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotelById(int id)
        {
            try
            {
                var hotel = await _hotelRepository.GetHotelById(id);
                if (hotel == null)
                    return NotFound();

                return Ok(hotel);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // POST: api/Hotel
        [HttpPost]
        public async Task<IActionResult> CreateHotel([FromBody] Hotel hotel)
        {
            try
            {
                if (hotel == null)
                    return BadRequest("Hotel object is null");

                await _hotelRepository.AddHotel(hotel);
                return CreatedAtAction(nameof(GetHotelById), new { id = hotel.hotelid }, hotel);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT: api/Hotel/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHotel(int id, [FromBody] Hotel hotel)
        {
            try
            {
                if (hotel == null || id != hotel.hotelid)
                    return BadRequest("Invalid hotel object");

                var existingHotel = await _hotelRepository.GetHotelById(id);
                if (existingHotel == null)
                    return NotFound();

                existingHotel.Customername = hotel.Customername;
                existingHotel.Customeraddress = hotel.Customeraddress;
                existingHotel.city = hotel.city;
                existingHotel.country = hotel.country;

                await _hotelRepository.UpdateHotel(existingHotel);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/Hotel/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            try
            {
                var hotel = await _hotelRepository.GetHotelById(id);
                if (hotel == null)
                    return NotFound();

                await _hotelRepository.DeleteHotel(id);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace final333.MODEL
{
    public class Hoteldbcontext : DbContext
    {
        public Hoteldbcontext(DbContextOptions<Hoteldbcontext> options) : base(options) { }

        DbSet<Hotel> Hotels{ get; set; }
        DbSet<Rooms> Rooms { get; set; }
        DbSet<User> users { get; set; }
        
    }
}

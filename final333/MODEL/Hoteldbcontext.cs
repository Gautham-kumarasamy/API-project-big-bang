using Microsoft.EntityFrameworkCore;

namespace final333.MODEL
{
    public class Hoteldbcontext : DbContext
    {
        public Hoteldbcontext(DbContextOptions<Hoteldbcontext> options) : base(options) { }

        public DbSet<Hotel> Hotels{ get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<User> users { get; set; }
        
    }
}

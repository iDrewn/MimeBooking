using Microsoft.EntityFrameworkCore;
using MimeBooking.Domain;

namespace MimeBooking
{
    class MimeBookingContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=MimeBooking;Integrated security=true");
        }
    }
}
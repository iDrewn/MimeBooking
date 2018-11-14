using MimeBooking.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MimeBooking.Services
{
    class ListBookings
    {
        public List<Booking> _ListBookings()
        {
            using (var context = new MimeBookingContext())
            {
                var bookings = context.Bookings.ToList();
                return bookings;
            }
        }
    }
}
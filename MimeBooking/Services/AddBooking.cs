using MimeBooking.Domain;
using System.Collections.Generic;

namespace MimeBooking.Services
{
    class AddBooking
    {
        public void BookingAdd(Booking bookingForAdding)
        {
            var bookings = new List<Booking>();

            using (var db = new MimeBookingContext())
            {
                db.Bookings.Add(bookingForAdding);
                db.SaveChanges();
            }
        }
    }
}
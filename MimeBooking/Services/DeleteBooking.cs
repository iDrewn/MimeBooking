using System.Linq;

namespace MimeBooking.Services
{
    class DeleteBooking
    {
        public void BookingDelete(string bookingForDeletion)
        {
            using (var db = new MimeBookingContext())
            {
                var foundBooking = db.Bookings.FirstOrDefault(x => x.EventName == bookingForDeletion);

                if (foundBooking == null) return;

                db.Bookings.Remove(foundBooking);
                db.SaveChanges();
            }
        }
    }
}
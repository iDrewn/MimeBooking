using System;

namespace MimeBooking.Domain
{
    class Booking
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Performer { get; set; }
        public Booking() {}

        public Booking(string eventName, DateTime date, string performer)
        {
            EventName = eventName;
            Date = date;
            Performer = performer;
        }
    }
}

//Booking
// The company handles booking in clients to events.
// A booking has an event name, a date, and a reference to one of its mime artists,
// commonly referred to as "performer" in the context of a booking.
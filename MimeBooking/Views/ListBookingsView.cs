using MimeBooking.Services;
using System;
using System.Threading;

namespace MimeBooking.Views
{
    class ListBookingsView
    {
        public void Display()
        {
            Console.Clear();
            var bookings = new ListBookings();

            Console.WriteLine($" Bookings: {bookings._ListBookings().Count}");
            Console.WriteLine("\nEvent\t\tDate\t\t\tPerformer");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var booking in bookings._ListBookings())
            {
                Console.WriteLine($"{booking.EventName}\t{booking.Date}\t{booking.Performer}");
            }

            Console.Write("\n (D) Delete or (Esc) Return to main menu");
            
            var deleteBooking = new DeleteBooking();
            var choice = Console.ReadKey(true);

            if (choice.Key == ConsoleKey.D)
            {
                Console.Clear();
                foreach (var booking in bookings._ListBookings())
                {
                    Console.WriteLine($" Event: {booking.EventName}");
                }

                Console.Write($"\n Delete> ");

                string bookingForDeletion = Console.ReadLine();
                deleteBooking.BookingDelete(bookingForDeletion);

                Console.WriteLine("Booking successfully deleted, returning to main menu");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
            }
        }
    }
}
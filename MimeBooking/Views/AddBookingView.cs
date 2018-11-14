using System;
using System.Threading;
using MimeBooking.Domain;
using MimeBooking.Services;

namespace MimeBooking.Views
{
    public class AddBookingView
    {
        public void Display()
        {
            var addBooking = new AddBooking();
            var done = false;
            
            do
            {
                Console.Clear();
                Console.WriteLine("# Add new appointment #");

                Console.Write("\nName of the event: ");
                var eventName = Console.ReadLine();
                Console.Write("Date of the event 'YYYYMMDD HH:MM': ");
                var date = Console.ReadLine();
                Console.Write("Name of the perfomer: ");
                var perfomer = Console.ReadLine();

                Console.WriteLine("Is this correct (Y)es (N)o");
                var confirm = Console.ReadKey(true);

                if (confirm.Key == ConsoleKey.Y)
                {
                    addBooking.BookingAdd(new Booking(eventName, date, perfomer));
                    Console.WriteLine("\nBooking added successfully");
                    Thread.Sleep(500);
                    done = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input, please try again");
                    Thread.Sleep(1000);
                }
                
            } while (!done);
        }
    }
}
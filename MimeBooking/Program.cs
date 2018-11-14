using MimeBooking.Views;

namespace MimeBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainMenuView = new MainMenuView();
            mainMenuView.Display();
        }
    }
}

/*
 * ToDo:
 * Bookings menu [*]
 * List bookings [*]
 * Register new client (mime artist) [*]
 * Register new booking [*]
 * List all bookings [*]
 * Remove booking [*]
 * Exit application [*]
 * Extra feature: List & remove clients 
 */
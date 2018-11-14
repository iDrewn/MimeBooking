using System;
using System.Threading;
using MimeBooking.Services;

namespace MimeBooking.Views
{
    class MainMenuView
    {
        private bool done = false;
        public void Display()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" # Main menu #\n");
                Console.WriteLine(" 1. Enlist new client");
                Console.WriteLine(" 2. Create new booking");
                Console.WriteLine(" 3. List bookings");
                Console.WriteLine(" 4. List clients");
                Console.WriteLine(" 5. Exit");
                Console.Write(" > ");

                var choice = Console.ReadKey(true);

                if (choice.Key == ConsoleKey.D1 || choice.Key == ConsoleKey.NumPad1)
                {
                    var enlistClientView = new EnlistClientView();
                    enlistClientView.Display();
                }
                else if (choice.Key == ConsoleKey.D2 || choice.Key == ConsoleKey.NumPad2)
                {
                    var createBookingView = new AddBookingView();
                    createBookingView.Display();
                }
                else if (choice.Key == ConsoleKey.D3 || choice.Key == ConsoleKey.NumPad3)
                {
                    var listBookingsView = new ListBookingsView();
                    listBookingsView.Display();
                }
                else if (choice.Key == ConsoleKey.D4 || choice.Key == ConsoleKey.NumPad4)
                {
                    var listClientsView = new ListClientsView();
                    listClientsView.Display();
                }
                else if (choice.Key == ConsoleKey.D5 || choice.Key == ConsoleKey.NumPad5)
                {
                    Console.Write("Terminating application.");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Thread.Sleep(250); Console.Write(".");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                    Thread.Sleep(500);
                }
            } while (!done);
        }
    }
}
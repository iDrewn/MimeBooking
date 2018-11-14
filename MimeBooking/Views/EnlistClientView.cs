using System;
using System.Threading;
using MimeBooking.Domain;
using MimeBooking.Services;

namespace MimeBooking.Views
{
    public class EnlistClientView
    {
        public void Display()
        {
            var addClient = new AddClient();
            var done = false;

            do
            {
                Console.Clear();
                Console.WriteLine("# Add new client #");

                Console.Write("\nFirstname: ");
                var fistName = Console.ReadLine();
                Console.Write("Lastname: ");
                var lastName = Console.ReadLine();
                Console.Write("Social security number: ");
                var socialSecurityNumber = Console.ReadLine();
                Console.Write("Main act: ");
                var mainAct = Console.ReadLine();

                Console.WriteLine("\nIs this correct (Y)es (N)o");
                var confirm = Console.ReadKey(true);
                
                    if (confirm.Key == ConsoleKey.Y)
                    {
                            addClient.ClientAdd(new Client(fistName, lastName, socialSecurityNumber, mainAct));
                            Console.WriteLine("\nClient added successfully");
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
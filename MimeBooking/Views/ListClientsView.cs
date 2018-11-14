using MimeBooking.Services;
using System;
using System.Threading;

namespace MimeBooking.Views
{
    class ListClientsView
    {
        public void Display()
        {
            Console.Clear();
            var clients = new ListClients();

            Console.WriteLine($" Clients: {clients._ListClients().Count}");
            Console.WriteLine("\nFirstname\tLastname\t\tMain act");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var client in clients._ListClients())
            {
                Console.WriteLine($"{client.FirstName}\t\t{client.LastName}\t\t\t{client.MainAct}");
            }

            Console.Write("\n (D) Delete or (Esc) Return to main menu");
            
            var deleteClient = new DeleteClient();
            var choice = Console.ReadKey(true);

            if (choice.Key == ConsoleKey.D)
            {
                Console.Clear();
                foreach (var client in clients._ListClients())
                {
                    Console.WriteLine($" Client: {client.FirstName}");
                }

                Console.Write($"\n Delete> ");

                string clientForDeletion = Console.ReadLine();
                deleteClient.ClientDelete(clientForDeletion);
                
                Thread.Sleep(500);
            }
        }
    }
}
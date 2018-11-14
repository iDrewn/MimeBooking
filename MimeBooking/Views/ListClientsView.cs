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
            Console.WriteLine("\nFirstname\t\tLastname\t\t\tMain act");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (var client in clients._ListClients())
            {
                Console.WriteLine($"{client.FirstName}\t{client.LastName}\t{client.MainAct}");
            }

            Console.Write("\n (D) Delete or (Esc) Return to main menu");
            
            var deleteClient = new DeleteClient();
            var choice = Console.ReadKey(true);

            if (choice.Key == ConsoleKey.D)
            {
                Console.Clear();
                foreach (var client in clients._ListClients())
                {
                    Console.WriteLine($" Event: {client.FirstName}");
                }

                Console.Write($"\n Delete> ");

                string clientForDeletion = Console.ReadLine();
                deleteClient.ClientDelete(clientForDeletion);

                Console.WriteLine("Client successfully deleted, returning to main menu");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
                Thread.Sleep(250); Console.Write(".");
            }
        }
    }
}
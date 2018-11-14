using MimeBooking.Domain;
using System.Collections.Generic;

namespace MimeBooking.Services
{
    class AddClient
    {
        public void ClientAdd(Client clientForAdding)
        {
            var clients = new List<Client>();

            using (var db = new MimeBookingContext())
            {
                db.Clients.Add(clientForAdding);
                db.SaveChanges();
            }
        }
    }
}
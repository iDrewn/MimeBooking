using MimeBooking.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MimeBooking.Services
{
    class ListClients
    {
        public List<Client> _ListClients()
        {
            using (var context = new MimeBookingContext())
            {
                var clients = context.Clients.ToList();
                return clients;
            }
        }
    }
}
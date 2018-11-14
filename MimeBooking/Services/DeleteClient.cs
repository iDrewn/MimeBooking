using System.Linq;

namespace MimeBooking.Services
{
    class DeleteClient
    {
        public void ClientDelete(string clientForDeletion)
        {
            using (var db = new MimeBookingContext())
            {
                var foundClient = db.Clients.FirstOrDefault(x => x.FirstName == clientForDeletion);

                if (foundClient == null) return;

                db.Clients.Remove(foundClient);
                db.SaveChanges();
            }
        }
    }
}
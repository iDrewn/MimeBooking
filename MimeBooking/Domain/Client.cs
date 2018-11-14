namespace MimeBooking.Domain
{
    class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string MainAct { get; set; }

        public Client() {}

        public Client(string firstName, string lastName, string socialSecurityNumber, string mainAct)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            MainAct = mainAct;
        }
    }
}

//Client
// A client is a mime artist that the company represents.
// A client has a first name, last name and social security number, as well as a main act, like The wall.
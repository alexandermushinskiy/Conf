namespace Conf.Management.Entities
{
    public class Attendee
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }

        public Attendee(string email, string firstName, string lastName)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
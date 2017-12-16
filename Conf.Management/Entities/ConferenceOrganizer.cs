namespace Conf.Management.Entities
{
    public class ConferenceOrganizer
    {
        public ConferenceOrganizer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; }

        public string Email { get; }
    }
}
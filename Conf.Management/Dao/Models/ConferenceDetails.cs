using System;

namespace Conf.Management.Dao.Models
{
    public class ConferenceDetails
    {
        public ConferenceDetails(Guid id, string code, string name, string description, string location, DateTime startDate, DateTime finishDate)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
            Location = location;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Guid Id { get; }

        public string Code { get; }

        public string Name { get; }

        public string Description { get; }

        public string Location { get; }

        public DateTimeOffset StartDate { get; }

        public DateTimeOffset FinishDate { get; }
    }
}
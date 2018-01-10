using System;
using System.Collections.Generic;
using Conf.Infrastructure.Extensibility;
using Conf.Management.Commands;

namespace Conf.Management.Entities
{
    public class Conference : IAggregateRoot
    {
        public Guid Id { get; set; }

        public string AccessCode { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public ConferenceOrganizer Organizer { get; set; }

        public string Venue { get; set; }

        public IEnumerable<SeatType> SeatTypes { get; set; }

        public void Handle(CreateConferenceCommand createConferenceCommand)
        {
            Id = createConferenceCommand.Id;
            AccessCode = createConferenceCommand.AccessCode;
            Name = createConferenceCommand.Name;
            Description = createConferenceCommand.Description;
            StartDate = createConferenceCommand.StartDate;
            FinishDate = createConferenceCommand.FinishDate;
            Organizer = new ConferenceOrganizer(createConferenceCommand.OwnerName, createConferenceCommand.OwnerEmail);
            Venue = createConferenceCommand.Venue;
        }
    }
}
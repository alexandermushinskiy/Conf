using Conf.Infrastructure.Extensibility.Messaging;
using Conf.Management.Commands;
using Conf.Management.Entities;
using Conf.Management.Extensibility.Repositories;

namespace Conf.Management.CommandHandlers
{
    public class ConferenceCommandHandler : ICommandHandler<CreateConferenceCommand>
    {
        private readonly IConferenceRepository conferenceRepository;

        public ConferenceCommandHandler(IConferenceRepository conferenceRepository)
        {
            this.conferenceRepository = conferenceRepository;
        }

        public void Handle(CreateConferenceCommand command)
        {
            Conference conference = new Conference();
            conference.Handle(command);

            conferenceRepository.Create(conference);
        }
    }
}
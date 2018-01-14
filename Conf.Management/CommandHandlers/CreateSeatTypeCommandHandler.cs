using System;
using System.Threading.Tasks;
using Conf.Infrastructure.Extensibility.Messaging;
using Conf.Management.Commands;
using Conf.Management.Entities;
using Conf.Management.Extensibility.Repositories;

namespace Conf.Management.CommandHandlers
{
    internal class CreateSeatTypeCommandHandler : ICommandHandler<CreateSeatTypeCommand>
    {
        private readonly IConferenceRepository conferenceRepository;

        public CreateSeatTypeCommandHandler(IConferenceRepository conferenceRepository)
        {
            this.conferenceRepository = conferenceRepository;
        }

        public void Handle(CreateSeatTypeCommand command)
        {
            Conference conference = conferenceRepository.GetById(command.ConferenceId);
            conference.Handle(command);

            conferenceRepository.Update(conference);
        }

        public Task HandleAsync(CreateSeatTypeCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
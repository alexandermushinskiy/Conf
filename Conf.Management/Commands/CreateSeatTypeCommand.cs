using System;
using Conf.Infrastructure.Extensibility.Messaging;

namespace Conf.Management.Commands
{
    public class CreateSeatTypeCommand : ICommand
    {
        public Guid Id { get; set; }

        public Guid ConferenceId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
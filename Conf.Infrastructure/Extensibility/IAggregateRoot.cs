using System;

namespace Conf.Infrastructure.Extensibility
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
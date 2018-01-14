using System.Threading.Tasks;

namespace Conf.Infrastructure.Extensibility.Messaging
{
    public interface ICommandHandler
    {
    }

    public interface ICommandHandler<in TCommand> : ICommandHandler
        where TCommand : ICommand
    {
        void Handle(TCommand command);
        Task HandleAsync(TCommand command);
    }
}
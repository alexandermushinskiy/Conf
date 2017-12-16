namespace Conf.Infrastructure.Extensibility.Messaging
{
    public interface ICommand
    {
    }

    public interface ICommand<out TCommandData> : ICommand
    {
        TCommandData Data { get; }
    }
}
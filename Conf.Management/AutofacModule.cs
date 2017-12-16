using Autofac;
using Conf.Infrastructure.Extensibility.Messaging;
using Conf.Management.CommandHandlers;
using Conf.Management.Commands;
using Conf.Management.Extensibility.Providers;
using Conf.Management.Providers;

namespace Conf.Management
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterProviders(builder);
            RegisterCommandHandlers(builder);
        }

        private void RegisterProviders(ContainerBuilder builder)
        {
            builder.RegisterType<AccessCodeProvider>().As<IAccessCodeProvider>();
            builder.RegisterType<GuidProvider>().As<IGuidProvider>();
        }

        private void RegisterCommandHandlers(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceCommandHandler>().As<ICommandHandler<CreateConferenceCommand>>();
        }
    }
}
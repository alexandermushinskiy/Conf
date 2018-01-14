using Autofac;
using Conf.Infrastructure.Extensibility.Messaging;
using Conf.Management.CommandHandlers;
using Conf.Management.Commands;
using Conf.Management.DataAccess.Dao;
using Conf.Management.DataAccess.Repositories;
using Conf.Management.Extensibility.Dao;
using Conf.Management.Extensibility.Providers;
using Conf.Management.Extensibility.Repositories;
using Conf.Management.Providers;

namespace Conf.Management
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterProviders(builder);
            RegisterCommandHandlers(builder);
            RegisterRepositories(builder);
            RegisterDaos(builder);
        }

        private static void RegisterProviders(ContainerBuilder builder)
        {
            builder.RegisterType<AccessCodeProvider>().As<IAccessCodeProvider>();
            builder.RegisterType<GuidProvider>().As<IGuidProvider>();
        }

        private static void RegisterCommandHandlers(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceCommandHandler>().As<ICommandHandler<CreateConferenceCommand>>();
            builder.RegisterType<CreateSeatTypeCommandHandler>().As<ICommandHandler<CreateSeatTypeCommand>>();
        }

        private static void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceRepository>().As<IConferenceRepository>();
        }

        private static void RegisterDaos(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceDao>().As<IConferenceDao>();
            builder.RegisterType<OrderDao>().As<IOrderDao>();
            builder.RegisterType<SeatTypesDao>().As<ISeatTypesDao>();
        }
    }
}
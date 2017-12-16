using Autofac;
using Conf.Management.Extensibility.Dao;
using Conf.Management.Extensibility.Repositories;
using Conf.Management.Infrastructure.DataAccess.Dao;
using Conf.Management.Infrastructure.DataAccess.Repositories;

namespace Conf.Management.DataAccess
{
    public class DataAccessAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterRepositories(builder);
            RegisterDaos(builder);
        }

        private void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceRepository>().As<IConferenceRepository>();
        }

        private void RegisterDaos(ContainerBuilder builder)
        {
            builder.RegisterType<ConferenceDao>().As<IConferenceDao>();
        }
    }
}
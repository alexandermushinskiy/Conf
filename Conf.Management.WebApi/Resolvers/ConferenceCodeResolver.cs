using AutoMapper;
using Conf.Management.Commands;
using Conf.Management.WebApi.Models.Requests;
using Conf.Management.Extensibility.Providers;

namespace Conf.Management.WebApi.Resolvers
{
    public class ConferenceCodeResolver : IValueResolver<CreateRequestModel, CreateConferenceCommand, string>
    {
        private readonly IAccessCodeProvider accessCodeProvider;

        public ConferenceCodeResolver(IAccessCodeProvider accessCodeProvider)
        {
            this.accessCodeProvider = accessCodeProvider;
        }

        public string Resolve(CreateRequestModel source, CreateConferenceCommand destination, string destMember, ResolutionContext context)
        {
            return accessCodeProvider.Generate();
        }
    }
}
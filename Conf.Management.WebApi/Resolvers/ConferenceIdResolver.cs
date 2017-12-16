using System;
using AutoMapper;
using Conf.Management.Domain.Commands;
using Conf.Management.Domain.Interfaces.Providers;
using Conf.Management.WebApi.Models.Requests;

namespace Conf.Management.WebApi.Resolvers
{
    public class ConferenceIdResolver : IValueResolver<CreateRequestModel, CreateConferenceCommand, Guid>
    {
        private readonly IGuidProvider guidProvider;

        public ConferenceIdResolver(IGuidProvider guidProvider)
        {
            this.guidProvider = guidProvider;
        }

        public Guid Resolve(CreateRequestModel source, CreateConferenceCommand destination, Guid destMember, ResolutionContext context)
        {
            return guidProvider.GetGuid();
        }
    }
}
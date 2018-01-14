using System;
using AutoMapper;
using Conf.Management.Commands;
using Conf.Management.Extensibility.Providers;
using Conf.Management.WebApi.Models.Requests;

namespace Conf.Management.WebApi.Resolvers
{
    public class SeatTypeIdResolver : IValueResolver<CreateSeatTypeRequestModel, CreateSeatTypeCommand, Guid>
    {
        private readonly IGuidProvider guidProvider;

        public SeatTypeIdResolver(IGuidProvider guidProvider)
        {
            this.guidProvider = guidProvider;
        }

        public Guid Resolve(CreateSeatTypeRequestModel source, CreateSeatTypeCommand destination, Guid destMember, ResolutionContext context)
        {
            return guidProvider.GetGuid();
        }
    }
}
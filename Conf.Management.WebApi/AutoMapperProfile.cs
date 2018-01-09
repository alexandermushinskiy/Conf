using AutoMapper;
using Conf.Management.Commands;
using Conf.Management.WebApi.Models.Requests;
using Conf.Management.WebApi.Resolvers;

namespace Conf.Management.WebApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateRequestModel, CreateConferenceCommand>()
                .ForMember(dest => dest.Id, opt => opt.ResolveUsing<ConferenceIdResolver>())
                .ForMember(dest => dest.AccessCode, opt => opt.ResolveUsing<ConferenceCodeResolver>());
        }
    }
}
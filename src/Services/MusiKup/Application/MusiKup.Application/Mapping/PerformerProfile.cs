using AutoMapper;
using MusiKup.Application.Dto.Request.Performer;
using MusiKup.Application.Dto.Response.Performer;
using MusiKup.Domain.Entities;

namespace MusiKup.Application.Mapping;

public class PerformerProfile : Profile
{
    public PerformerProfile()
    {
        CreateMap<PerformerCreateRequest, Performer>()
            .ForMember(P => P.NickName, opt => opt.MapFrom(src => src.Nickname))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));

        CreateMap<PerformerUpdateRequest, Performer>()
            .ForMember(P => P.NickName, opt => opt.MapFrom(src => src.Nickname))
            .ForMember(P => P.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));

        CreateMap<Performer, PerformerGetByIdResponse>()
            .ForMember(P => P.Nickname, opt => opt.MapFrom(src => src.NickName))
            .ForMember(P => P.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));
        
        CreateMap<Performer, PerformerCreateResponse>()
            .ForMember(P => P.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));

        CreateMap<Performer, PerformerUpdateResponse>()
            .ForMember(P => P.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));
    }
}
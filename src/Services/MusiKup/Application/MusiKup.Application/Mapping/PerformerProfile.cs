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
            .ForMember(P => P.FullName.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
            .ForMember(P => P.FullName.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
            .ForMember(P => P.FullName.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName));
        CreateMap<PerformerUpdateRequest, Performer>()
            .ForMember(P => P.NickName, opt => opt.MapFrom(src => src.Nickname))
            .ForMember(P => P.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(P => P.FullName.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
            .ForMember(P => P.FullName.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
            .ForMember(P => P.FullName.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName));
        CreateMap<Performer, PerformerCreateResponse>()
            .ForMember(P => P.FullName.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
            .ForMember(P => P.FullName.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
            .ForMember(P => P.FullName.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName));
        CreateMap<Performer, PerformerUpdateResponse>()
            .ForMember(P => P.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(P => P.FullName.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
            .ForMember(P => P.FullName.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
            .ForMember(P => P.FullName.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName));
    }
}
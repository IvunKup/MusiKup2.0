using AutoMapper;
using MusiKup.Application.Dto.Request.Playlist;
using MusiKup.Application.Dto.Response.Playlist;
using MusiKup.Domain.Entities;

namespace MusiKup.Application.Mapping;

public class PlaylistProfile : Profile
{
    public PlaylistProfile()
    {
        CreateMap<PlaylistCreateRequest, Playlist>()
            .ForMember(P => P.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(P => P.Description, opt => opt.MapFrom(src => src.Description));
        CreateMap<PlaylistUpdateRequest, Playlist>()
            .ForMember(P => P.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(P => P.Description, opt => opt.MapFrom(src => src.Description));
        CreateMap<Playlist, PlaylistCreateResponse>()
            .ForMember(P => P.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(P => P.Description, opt => opt.MapFrom(src => src.Description));
        CreateMap<Playlist, PlaylistUpdateResponse>()
            .ForMember(P => P.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(P => P.Description, opt => opt.MapFrom(src => src.Description));
    }
}
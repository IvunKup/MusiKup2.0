using AutoMapper;
using MusiKup.Application.Dto.Request.PlaylistFile;
using MusiKup.Application.Dto.Response.PlaylistFile;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Mapping;

public class PlaylistFileProfile : Profile
{
    public PlaylistFileProfile()
    {
        CreateMap<PlaylistFileCreateRequest, PlaylistFile>()
            .ForMember(A => A.PlaylistId, src => src.MapFrom(src => src.PlaylistId));
        CreateMap<PlaylistFile, PlaylistFileCreateResponse>()
            .ForMember(A => A.PlaylistId, src => src.MapFrom(src => src.PlaylistId));
        CreateMap<PlaylistFileUpdateRequest, PlaylistFile>()
            .ForMember(A => A.PlaylistId, src => src.MapFrom(src => src.PlaylistId));
        CreateMap<PlaylistFile, PlaylistFileUpdateResponse>()
            .ForMember(A => A.PlaylistId, src => src.MapFrom(src => src.PlaylistId));
    }
}
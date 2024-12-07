using AutoMapper;
using MusiKup.Application.Dto.Request.TrackFile;
using MusiKup.Application.Dto.Response.TrackFile;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Mapping;

public class TrackFileProfile : Profile
{
    public TrackFileProfile()
    {
        CreateMap<TrackFileCreateRequest, TrackFile>()
            .ForMember(A => A.TrackId, src => src.MapFrom(src => src.TrackId));
        CreateMap<TrackFile, TrackFileCreateResponse>()
            .ForMember(A => A.TrackId, src => src.MapFrom(src => src.TrackId));
        CreateMap<TrackFileUpdateRequest, TrackFile>()
            .ForMember(A => A.TrackId, src => src.MapFrom(src => src.TrackId));
        CreateMap<TrackFile, TrackFileUpdateResponse>()
            .ForMember(A => A.TrackId, src => src.MapFrom(src => src.TrackId));
    }
}
using AutoMapper;
using MusiKup.Application.Dto.Request.Track;
using MusiKup.Application.Dto.Response.Track;
using MusiKup.Domain.Entities;

namespace MusiKup.Application.Mapping;

public class TrackProfile : Profile
{
    public TrackProfile()
    {
        CreateMap<TrackCreateRequest, Track>()
            .ForMember(A => A.Title, opt => opt.MapFrom(A => A.Title));
        CreateMap<TrackUpdateRequest, Track>()
            .ForMember(A => A.Title, opt => opt.MapFrom(A => A.Title));
        CreateMap<Track, TrackCreateResponse>()
            .ForMember(A => A.Title, opt => opt.MapFrom(A => A.Title));
        CreateMap<Track, TrackUpdateResponse>()
            .ForMember(A => A.Title, opt => opt.MapFrom(A => A.Title));
    }
}
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
            .ForMember(A => A.Id, opt => opt.MapFrom(A => A.Id))
            .ForMember(A => A.Title, opt => opt.MapFrom(A => A.Title));

        CreateMap<Track, TrackCreateResponse>()
            .ForMember(A => A.Id, opt => opt.MapFrom(A => A.Id))
            .ForMember(A => A.Title, opt => opt.MapFrom(A => A.Title))
            .ForMember(A => A.PerformerId, opt => opt.MapFrom(A => A.PerformerId))
            .ForMember(A => A.AuthorId, opt => opt.MapFrom(A => A.AuthorId));

        CreateMap<Track, TrackGetByIdResponse>()
            .ForMember(A => A.Title, opt => opt.MapFrom(A => A.Title))
            .ForMember(A => A.Id, opt => opt.MapFrom(A => A.Id))
            .ForMember(A => A.PerformerId, opt => opt.MapFrom(A => A.PerformerId))
            .ForMember(A => A.AuthorId, opt => opt.MapFrom(A => A.AuthorId));

        CreateMap<Track, TrackUpdateResponse>()
            .ForMember(A => A.Id, opt => opt.MapFrom(A => A.Id))
            .ForMember(A => A.Title, opt => opt.MapFrom(A => A.Title))
            .ForMember(A => A.PerformerId, opt => opt.MapFrom(A => A.PerformerId))
            .ForMember(A => A.AuthorId, opt => opt.MapFrom(A => A.AuthorId));

    }
}
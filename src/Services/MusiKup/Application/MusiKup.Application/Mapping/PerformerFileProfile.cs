using AutoMapper;
using MusiKup.Application.Dto.Request.PerformerFile;
using MusiKup.Application.Dto.Response.PerformerFile;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Mapping;

public class PerformerFileProfile : Profile
{
    public PerformerFileProfile()
    {
        CreateMap<PerformerFileCreateRequest, PerformerFile>()
            .ForMember(A => A.PerformerId, src => src.MapFrom(src => src.PerformerId));
        CreateMap<PerformerFile, PerformerFileCreateResponse>()
            .ForMember(A => A.PerformerId, src => src.MapFrom(src => src.PerformerId));
        CreateMap<PerformerFileUpdateRequest, PerformerFile>()
            .ForMember(A => A.PerformerId, src => src.MapFrom(src => src.PerformerId));
        CreateMap<PerformerFile, PerformerFileUpdateResponse>()
            .ForMember(A => A.PerformerId, src => src.MapFrom(src => src.PerformerId));
    }
}
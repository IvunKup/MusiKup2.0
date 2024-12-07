using AutoMapper;
using MusiKup.Application.Dto.Request.AuthorFile;
using MusiKup.Application.Dto.Response.AuthorFile;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Mapping;

public class AuthorFileProfile : Profile
{
    public AuthorFileProfile()
    {
        CreateMap<AuthorFileCreateRequest, AuthorFile>()
            .ForMember(A => A.AuthorId, src => src.MapFrom(src => src.AuthorId));
        CreateMap<AuthorFile, AuthorFileCreateResponse>()
            .ForMember(A => A.AuthorId, src => src.MapFrom(src => src.AuthorId));
        CreateMap<AuthorFileUpdateRequest, AuthorFile>()
            .ForMember(A => A.AuthorId, src => src.MapFrom(src => src.AuthorId));
        CreateMap<AuthorFile, AuthorFileUpdateResponse>()
            .ForMember(A => A.AuthorId, src => src.MapFrom(src => src.AuthorId));
    }
}
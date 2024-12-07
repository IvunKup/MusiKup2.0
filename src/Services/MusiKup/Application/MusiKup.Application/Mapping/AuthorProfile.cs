using AutoMapper;
using MusiKup.Application.Dto.Request.Author;
using MusiKup.Application.Dto.Response.Author;
using MusiKup.Domain.Entities;

namespace MusiKup.Application.Mapping;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<AuthorCreateRequest, Author>()
            .ForMember(A => A.NickName, opt => opt.MapFrom(src => src.Nickname))
            .ForMember(A => A.FullName.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
            .ForMember(A => A.FullName.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
            .ForMember(A => A.FullName.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName));
        CreateMap<AuthorUpdateRequest, Author>()
            .ForMember(A => A.NickName, opt => opt.MapFrom(src => src.Nickname))
            .ForMember(A => A.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(A => A.FullName.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
            .ForMember(A => A.FullName.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
            .ForMember(A => A.FullName.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName));
        CreateMap<Author, AuthorCreateResponse>()
            .ForMember(A => A.FullName.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
            .ForMember(A => A.FullName.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
            .ForMember(A => A.FullName.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName));
        CreateMap<Author, AuthorUpdateResponse>()
            .ForMember(A => A.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(A => A.FullName.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
            .ForMember(A => A.FullName.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
            .ForMember(A => A.FullName.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName));

    }
}
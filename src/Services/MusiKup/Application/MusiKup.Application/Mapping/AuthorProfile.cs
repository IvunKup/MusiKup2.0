using AutoMapper;
using MusiKup.Application.Dto;
using MusiKup.Application.Dto.Request.Author;
using MusiKup.Application.Dto.Response.Author;
using MusiKup.Domain.Entities;
using MusiKup.Domain.ValueObjects;

namespace MusiKup.Application.Mapping;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<AuthorCreateRequest, Author>()
            .ForMember(A => A.NickName, opt => opt.MapFrom(src => src.Nickname))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));

        CreateMap<AuthorUpdateRequest, Author>()
            .ForMember(A => A.NickName, opt => opt.MapFrom(src => src.Nickname))
            .ForMember(A => A.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));

        CreateMap<Author, AuthorCreateResponse>()
            .ForMember(A => A.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(A => A.FullName, opt => opt.MapFrom(src => new FullName(src.FullName.FirstName, src.FullName.LastName,  src.FullName.MiddleName)));

        CreateMap<Author, AuthorUpdateResponse>()
            .ForMember(A => A.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));

        CreateMap<Author, AuthorGetByIdResponse>()
            .ForMember(A => A.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(A => A.Nickname, opt => opt.MapFrom(src => src.NickName))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));


        CreateMap<FullNameDto, FullName>()
            .ConstructUsing(src => new FullName(src.FirstName, src.LastName, src.MiddleName));

        CreateMap<FullName, FullNameDto>();
    }
}
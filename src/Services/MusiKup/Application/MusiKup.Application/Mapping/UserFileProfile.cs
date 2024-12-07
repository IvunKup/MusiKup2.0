using AutoMapper;
using MusiKup.Application.Dto.Request.UserFile;
using MusiKup.Application.Dto.Response.UserFile;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Mapping;

public class UserFileProfile : Profile
{
    public UserFileProfile()
    {
        CreateMap<UserFile, UserFileCreateResponse>()
            .ForMember(A => A.UserId, src => src.MapFrom(src => src.UserId));
        CreateMap<UserFileUpdateRequest, UserFile>()
            .ForMember(A => A.UserId, src => src.MapFrom(src => src.UserId));
        CreateMap<UserFile, UserFileUpdateResponse>()
            .ForMember(A => A.UserId, src => src.MapFrom(src => src.UserId));
    }
}
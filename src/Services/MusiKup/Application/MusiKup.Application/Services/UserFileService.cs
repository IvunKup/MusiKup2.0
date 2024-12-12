using AutoMapper;
using MusiKup.Application.Dto.Request.UserFile;
using MusiKup.Application.Dto.Response.UserFile;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Services;

public class UserFileService
{
    private IRepository<UserFile> UserFileRepository { get; set; }
    private IMapper Mapper { get; set; }

    public UserFileService(IRepository<UserFile> userFileRepository, IMapper mapper)
    {
        UserFileRepository = userFileRepository;
        Mapper = mapper;
    }

    public async Task<UserFileCreateResponse> CreateAsync(UserFileCreateRequest request)
    {
        var userFile = Mapper.Map<UserFile>(request);
        var response = await UserFileRepository.AddAsync(userFile);
        await UserFileRepository.SaveChangesAsync();
        return Mapper.Map<UserFileCreateResponse>(response);
    }

    public async Task<UserFileGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await UserFileRepository.GetByIdAsync(id);
        return Mapper.Map<UserFileGetByIdResponse>(response);
    }

    public UserFileUpdateResponse Update(UserFileUpdateRequest request)
    {
        var userFile = Mapper.Map<UserFile>(request);
        var response = UserFileRepository.Update(userFile);
        UserFileRepository.SaveChanges();
        return Mapper.Map<UserFileUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await UserFileRepository.RemoveAsync(id);
        await UserFileRepository.SaveChangesAsync();
    }
}
using AutoMapper;
using MusiKup.Application.Dto.Request.AuthorFile;
using MusiKup.Application.Dto.Response.AuthorFile;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Services;

public class AuthorFileService
{
    private IRepository<AuthorFile> AuthorFileRepository { get; set; }
    private IMapper Mapper { get; set; }

    public AuthorFileService(IRepository<AuthorFile> authorFileRepository, IMapper mapper)
    {
        AuthorFileRepository = authorFileRepository;
        Mapper = mapper;
    }

    public async Task<AuthorFileCreateResponse> CreateAsync(AuthorFileCreateRequest request)
    {
        var author = Mapper.Map<AuthorFile>(request);
        var response = await AuthorFileRepository.AddAsync(author);
        await AuthorFileRepository.SaveChangesAsync();
        var googleDriveId = await FileService.UploadFileAsync(request.Data);
        author.GoogleDriveName = googleDriveId;
        return Mapper.Map<AuthorFileCreateResponse>(response);
    }

    public async Task<AuthorFileGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await AuthorFileRepository.GetByIdAsync(id);
        return Mapper.Map<AuthorFileGetByIdResponse>(response);
    }

    public AuthorFileUpdateResponse Update(AuthorFileUpdateRequest request)
    {
        var author = Mapper.Map<AuthorFile>(request);
        var response = AuthorFileRepository.Update(author);
        AuthorFileRepository.SaveChanges();
        return Mapper.Map<AuthorFileUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await AuthorFileRepository.RemoveAsync(id);
        await AuthorFileRepository.SaveChangesAsync();
    }
}
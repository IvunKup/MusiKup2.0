using AutoMapper;
using MusiKup.Application.Dto.Request.PlaylistFile;
using MusiKup.Application.Dto.Response.PlaylistFile;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Services;

public class PlaylistFileService
{
    private IRepository<PlaylistFile> PlaylistFileRepository { get; set; }
    private IMapper Mapper { get; set; }

    public PlaylistFileService(IRepository<PlaylistFile> playlistFileRepository, IMapper mapper)
    {
        PlaylistFileRepository = playlistFileRepository;
        Mapper = mapper;
    }

    public async Task<PlaylistFileCreateResponse> CreateAsync(PlaylistFileCreateRequest request)
    {
        var playlistFile = Mapper.Map<PlaylistFile>(request);
        var response = await PlaylistFileRepository.AddAsync(playlistFile);
        await PlaylistFileRepository.SaveChangesAsync();
        return Mapper.Map<PlaylistFileCreateResponse>(response);
    }

    public async Task<PlaylistFileGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await PlaylistFileRepository.GetByIdAsync(id);
        return Mapper.Map<PlaylistFileGetByIdResponse>(response);
    }

    public PlaylistFileUpdateResponse Update(PlaylistFileUpdateRequest request)
    {
        var playlistFile = Mapper.Map<PlaylistFile>(request);
        var response = PlaylistFileRepository.Update(playlistFile);
        PlaylistFileRepository.SaveChanges();
        return Mapper.Map<PlaylistFileUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await PlaylistFileRepository.RemoveAsync(id);
        await PlaylistFileRepository.SaveChangesAsync();
    }
}
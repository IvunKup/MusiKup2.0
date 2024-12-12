using AutoMapper;
using MusiKup.Application.Dto.Request.Playlist;
using MusiKup.Application.Dto.Response.Playlist;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;

namespace MusiKup.Application.Services;

public class PlaylistService
{
    private IRepository<Playlist> PlaylistRepository { get; set; }
    private IMapper Mapper { get; set; }

    public PlaylistService(IRepository<Playlist> playlistRepository, IMapper mapper)
    {
        PlaylistRepository = playlistRepository;
        Mapper = mapper;
    }

    public async Task<PlaylistCreateResponse> CreateAsync(PlaylistCreateRequest request)
    {
        var playlist = Mapper.Map<Playlist>(request);
        var response = await PlaylistRepository.AddAsync(playlist);
        await PlaylistRepository.SaveChangesAsync();
        return Mapper.Map<PlaylistCreateResponse>(response);
    }

    public async Task<PlaylistGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await PlaylistRepository.GetByIdAsync(id);
        return Mapper.Map<PlaylistGetByIdResponse>(response);
    }

    public PlaylistUpdateResponse Update(PlaylistUpdateRequest request)
    {
        var playlist = Mapper.Map<Playlist>(request);
        var response = PlaylistRepository.Update(playlist);
        PlaylistRepository.SaveChanges();
        return Mapper.Map<PlaylistUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await PlaylistRepository.RemoveAsync(id);
        await PlaylistRepository.SaveChangesAsync();
    }
}
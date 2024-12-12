using AutoMapper;
using MusiKup.Application.Dto.Request.Track;
using MusiKup.Application.Dto.Response.Track;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;

namespace MusiKup.Application.Services;

public class TrackService
{
    private IRepository<Track> TrackRepository { get; set; }
    private IMapper Mapper { get; set; }

    public TrackService(IRepository<Track> trackRepository, IMapper mapper)
    {
        TrackRepository = trackRepository;
        Mapper = mapper;
    }

    public async Task<TrackCreateResponse> CreateAsync(TrackCreateRequest request)
    {
        var track = Mapper.Map<Track>(request);
        var response = await TrackRepository.AddAsync(track);
        await TrackRepository.SaveChangesAsync();
        return Mapper.Map<TrackCreateResponse>(response);
    }

    public async Task<TrackGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await TrackRepository.GetByIdAsync(id);
        return Mapper.Map<TrackGetByIdResponse>(response);
    }

    public TrackUpdateResponse Update(TrackUpdateRequest request)
    {
        var track = Mapper.Map<Track>(request);
        var response = TrackRepository.Update(track);
        TrackRepository.SaveChanges();
        return Mapper.Map<TrackUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await TrackRepository.RemoveAsync(id);
        await TrackRepository.SaveChangesAsync();
    }
}
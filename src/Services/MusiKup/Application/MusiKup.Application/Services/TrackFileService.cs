using AutoMapper;
using MusiKup.Application.Dto.Request.TrackFile;
using MusiKup.Application.Dto.Response.TrackFile;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Services;

public class TrackFileService
{
    private IRepository<TrackFile> TrackFileRepository { get; set; }
    private IMapper Mapper { get; set; }

    public TrackFileService(IRepository<TrackFile> trackFileRepository, IMapper mapper)
    {
        TrackFileRepository = trackFileRepository;
        Mapper = mapper;
    }

    public async Task<TrackFileCreateResponse> CreateAsync(TrackFileCreateRequest request)
    {
        var trackFile = Mapper.Map<TrackFile>(request);
        var response = await TrackFileRepository.AddAsync(trackFile);
        await TrackFileRepository.SaveChangesAsync();
        return Mapper.Map<TrackFileCreateResponse>(response);
    }

    public async Task<TrackFileGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await TrackFileRepository.GetByIdAsync(id);
        return Mapper.Map<TrackFileGetByIdResponse>(response);
    }

    public TrackFileUpdateResponse Update(TrackFileUpdateRequest request)
    {
        var trackFile = Mapper.Map<TrackFile>(request);
        var response = TrackFileRepository.Update(trackFile);
        TrackFileRepository.SaveChanges();
        return Mapper.Map<TrackFileUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await TrackFileRepository.RemoveAsync(id);
        await TrackFileRepository.SaveChangesAsync();
    }
}
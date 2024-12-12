using AutoMapper;
using MusiKup.Application.Dto.Request.PerformerFile;
using MusiKup.Application.Dto.Response.PerformerFile;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities.Files;

namespace MusiKup.Application.Services;

public class PerformerFileService
{
    private IRepository<PerformerFile> PerformerFileRepository { get; set; }
    private IMapper Mapper { get; set; }

    public PerformerFileService(IRepository<PerformerFile> performerFileRepository, IMapper mapper)
    {
        PerformerFileRepository = performerFileRepository;
        Mapper = mapper;
    }

    public async Task<PerformerFileCreateResponse> CreateAsync(PerformerFileCreateRequest request)
    {
        var performerFile = Mapper.Map<PerformerFile>(request);
        var response = await PerformerFileRepository.AddAsync(performerFile);
        await PerformerFileRepository.SaveChangesAsync();
        return Mapper.Map<PerformerFileCreateResponse>(response);
    }

    public async Task<PerformerFileGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await PerformerFileRepository.GetByIdAsync(id);
        return Mapper.Map<PerformerFileGetByIdResponse>(response);
    }

    public PerformerFileUpdateResponse Update(PerformerFileUpdateRequest request)
    {
        var performerFile = Mapper.Map<PerformerFile>(request);
        var response = PerformerFileRepository.Update(performerFile);
        PerformerFileRepository.SaveChanges();
        return Mapper.Map<PerformerFileUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await PerformerFileRepository.RemoveAsync(id);
        await PerformerFileRepository.SaveChangesAsync();
    }
}
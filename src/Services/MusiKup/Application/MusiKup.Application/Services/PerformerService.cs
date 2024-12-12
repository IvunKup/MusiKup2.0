using AutoMapper;
using MusiKup.Application.Dto.Request.Performer;
using MusiKup.Application.Dto.Response.Performer;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;

namespace MusiKup.Application.Services;

public class PerformerService
{
    private IRepository<Performer> PerformerRepository { get; set; }
    private IMapper Mapper { get; set; }

    public PerformerService(IRepository<Performer> performerRepository, IMapper mapper)
    {
        PerformerRepository = performerRepository;
        Mapper = mapper;
    }

    public async Task<PerformerCreateResponse> CreateAsync(PerformerCreateRequest request)
    {
        var performer = Mapper.Map<Performer>(request);
        var response = await PerformerRepository.AddAsync(performer);
        await PerformerRepository.SaveChangesAsync();
        return Mapper.Map<PerformerCreateResponse>(response);
    }

    public async Task<PerformerGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await PerformerRepository.GetByIdAsync(id);
        return Mapper.Map<PerformerGetByIdResponse>(response);
    }

    public PerformerUpdateResponse Update(PerformerUpdateRequest request)
    {
        var performer = Mapper.Map<Performer>(request);
        var response = PerformerRepository.Update(performer);
        PerformerRepository.SaveChanges();
        return Mapper.Map<PerformerUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await PerformerRepository.RemoveAsync(id);
        await PerformerRepository.SaveChangesAsync();
    }
}
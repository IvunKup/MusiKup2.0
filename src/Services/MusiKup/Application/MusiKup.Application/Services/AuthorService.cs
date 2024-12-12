using AutoMapper;
using MusiKup.Application.Dto.Request.Author;
using MusiKup.Application.Dto.Response.Author;
using MusiKup.Application.Interfases;
using MusiKup.Domain.Entities;

namespace MusiKup.Application.Services;

public class AuthorService
{
    private IRepository<Author> AuthorRepository { get; set; }
    private IMapper Mapper { get; set; }

    public AuthorService(IRepository<Author> authorRepository, IMapper mapper)
    {
        AuthorRepository = authorRepository;
        Mapper = mapper;
    }

    public async Task<AuthorCreateResponse> CreateAsync(AuthorCreateRequest request)
    {
        var author = Mapper.Map<Author>(request);
        var response = await AuthorRepository.AddAsync(author);
        await AuthorRepository.SaveChangesAsync();
        return Mapper.Map<AuthorCreateResponse>(response);
    }

    public async Task<AuthorGetByIdResponse> GetByIdAsync(Guid id)
    {
        var response = await AuthorRepository.GetByIdAsync(id);
        return Mapper.Map<AuthorGetByIdResponse>(response);
    }

    public AuthorUpdateResponse Update(AuthorUpdateRequest request)
    {
        var author = Mapper.Map<Author>(request);
        var response = AuthorRepository.Update(author);
        AuthorRepository.SaveChanges();
        return Mapper.Map<AuthorUpdateResponse>(response);
    }

    public async Task DeleteAsync(Guid id)
    {
        await AuthorRepository.RemoveAsync(id);
        await AuthorRepository.SaveChangesAsync();
    }
}
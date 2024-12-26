using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Dto.Request.AuthorFile;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class AuthorFileController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] AuthorFileCreateRequest request,
        [FromServices] AuthorFileService service)
    {
        var result = await service.CreateAsync(request);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetByIdAsync(Guid id,
        [FromServices] AuthorFileService service)
    {
        var result = await service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut]
    public IActionResult UpdateAsync([FromBody] AuthorFileUpdateRequest request,
        [FromServices] AuthorFileService service)
    {
        var result = service.Update(request);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id,
        [FromServices] AuthorFileService service)
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}
using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Dto.Request.Author;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class AuthorController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateAsync([FromBody] AuthorCreateRequest request,
        [FromServices] AuthorService service)
    {
        var result = await service.CreateAsync(request);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult> GetByIdAsync(Guid id,
        [FromServices] AuthorService service)
    {
        var result = await service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut]
    public ActionResult UpdateAsync([FromBody] AuthorUpdateRequest request,
        [FromServices] AuthorService service)
    {
        var result = service.Update(request);
        return Ok(result);
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteAsinc(Guid id,
        [FromServices] AuthorService service)
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}
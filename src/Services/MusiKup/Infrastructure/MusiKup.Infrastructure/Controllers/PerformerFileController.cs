using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Dto.Request.PerformerFile;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class PerformerFileController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] PerformerFileCreateRequest request,
        [FromServices] PerformerFileService service)
    {
        var result = await service.CreateAsync(request);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetByIdAsync(Guid id,
        [FromServices] PerformerFileService service)
    {
        var result = await service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut]
    public IActionResult UpdateAsync([FromBody] PerformerFileUpdateRequest request,
        [FromServices] PerformerFileService service)
    {
        var result = service.Update(request);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id,
        [FromServices] PerformerFileService service)
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}
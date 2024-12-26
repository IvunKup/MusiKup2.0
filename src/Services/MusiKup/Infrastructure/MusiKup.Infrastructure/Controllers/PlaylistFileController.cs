using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Dto.Request.PlaylistFile;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class PlaylistFileController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] PlaylistFileCreateRequest request,
        [FromServices] PlaylistFileService service)
    {
        var result = await service.CreateAsync(request);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult> GetByIdAsync(Guid id,
        [FromServices] PlaylistFileService service)
    {
        var result = await service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut]
    public ActionResult UpdateAsync([FromBody] PlaylistFileUpdateRequest request,
        [FromServices] PlaylistFileService service)
    {
        var result = service.Update(request);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteAsync(Guid id,
        [FromServices] PlaylistFileService service)
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}
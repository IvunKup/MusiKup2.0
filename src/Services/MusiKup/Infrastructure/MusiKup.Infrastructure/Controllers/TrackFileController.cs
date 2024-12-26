using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Dto.Request.TrackFile;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class TrackFileController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateAsync([FromBody] TrackFileCreateRequest request,
        [FromServices] TrackFileService service)
    {
        var result = await service.CreateAsync(request);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult> GetByIdAsync(Guid id,
        [FromServices] TrackFileService service)
    {
        var result = await service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut]
    public ActionResult UpdateAsync([FromBody] TrackFileUpdateRequest request,
        [FromServices] TrackFileService service)
    {
        var result = service.Update(request);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteAsync(Guid id,
        [FromServices] TrackFileService service)
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}
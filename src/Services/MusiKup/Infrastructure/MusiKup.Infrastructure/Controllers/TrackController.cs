using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Dto.Request.Track;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class TrackController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateAsync([FromBody] TrackCreateRequest request,
        [FromServices] TrackService service)
    {
        var result = await service.CreateAsync(request);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult> GetByIdAsync(Guid id,
        [FromServices] TrackService service)
    {
        var result = await service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut]
    public ActionResult UpdateAsync([FromBody] TrackUpdateRequest request,
        [FromServices] TrackService service)
    {
        var result = service.Update(request);
        return Ok(result);
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteAsinc(Guid id,
        [FromServices] TrackService service)
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}
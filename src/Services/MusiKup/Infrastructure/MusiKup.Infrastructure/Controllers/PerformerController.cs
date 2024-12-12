using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Dto.Request.Performer;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class PerformerController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateAsync([FromBody] PerformerCreateRequest request,
        [FromServices] PerformerService service)
    {
        var result = await service.CreateAsync(request);
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult> GetByIdAsync(Guid id,
        [FromServices] PerformerService service)
    {
        var result = await service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut]
    public ActionResult UpdateAsync([FromBody] PerformerUpdateRequest request,
        [FromServices] PerformerService service)
    {
        var result = service.Update(request);
        return Ok(result);
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteAsinc(Guid id,
        [FromServices] PerformerService service)
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}
using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Dto.Request.UserFile;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class UserFileController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateAsync([FromBody] UserFileCreateRequest request,
        [FromServices] UserFileService service)
    {
        var result = await service.CreateAsync(request);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult> GetByIdAsync(Guid id,
        [FromServices] UserFileService service)
    {
        var result = await service.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPut]
    public ActionResult UpdateAsync([FromBody] UserFileUpdateRequest request,
        [FromServices] UserFileService service)
    {
        var result = service.Update(request);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteAsync(Guid id,
        [FromServices] UserFileService service)
    {
        await service.DeleteAsync(id);
        return NoContent();
    }
}
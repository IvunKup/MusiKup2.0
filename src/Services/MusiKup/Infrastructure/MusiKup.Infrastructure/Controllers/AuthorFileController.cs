using Microsoft.AspNetCore.Mvc;
using MusiKup.Application.Services;

namespace MusiKup.Infrastructure.Controllers;

public class AuthorFileController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateAsync(
        Guid userId,
        Guid authorId,
        Guid fileId,
        [FromServices] AuthorFileService service)
    {
        
    }
}
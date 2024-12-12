// using Microsoft.AspNetCore.Mvc;
// using MusiKup.Application.Dto.Request.Playlist;
// using MusiKup.Application.Services;
//
// namespace MusiKup.Infrastructure.Controllers;
//
// [ApiController]
// [Route("/api/[controller]")]
// public class PlaylistController : ControllerBase
// {
//     [HttpPost]
//     public async Task<ActionResult> CreateAsync([FromBody] PlaylistCreateRequest request,
//         [FromServices] PlaylistService service)
//     {
//         var result = await service.CreateAsync(request);
//         return Ok(result);
//     }
//
//     [HttpGet]
//     public async Task<ActionResult> GetByIdAsync(Guid id,
//         [FromServices] PlaylistService service)
//     {
//         var result = await service.GetByIdAsync(id);
//         return Ok(result);
//     }
//
//     [HttpPut]
//     public ActionResult UpdateAsync([FromBody] PlaylistUpdateRequest request,
//         [FromServices] PlaylistService service)
//     {
//         var result = service.Update(request);
//         return Ok(result);
//     }
//
//     [HttpDelete]
//     public async Task<ActionResult> DeleteAsinc(Guid id,
//         [FromServices] PlaylistService service)
//     {
//         await service.DeleteAsync(id);
//         return NoContent();
//     }
// }
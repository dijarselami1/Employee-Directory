using EmployeeDirectory.Models.Data;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/upload")]
public class UploadController : ControllerBase
{
    private readonly AppDbContext _db;

    public UploadController(AppDbContext db)
    {
        _db = db;
    }

    [HttpPost("save")]
    public async Task<IActionResult> Save([FromForm] IFormFile files)
    {
        if (files == null || files.Length == 0)
        {
            return BadRequest("No file uploaded.");
        }

        using var ms = new MemoryStream();
        await files.CopyToAsync(ms);
        byte[] fileBytes = ms.ToArray();

        // ❗ Store this into a temporary cache or session instead,
        // because at this point, your newEmployee is not created yet
        // This is a key issue if employee is not saved yet

        HttpContext.Session.Set("UploadedPhoto", fileBytes); // requires session setup

        return Ok();
    }
}

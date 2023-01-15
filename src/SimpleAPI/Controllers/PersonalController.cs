using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonalController : ControllerBase
{
    [HttpGet("GetName")]
    public ActionResult<string> GetName() {
        return "Masum";
    }
}
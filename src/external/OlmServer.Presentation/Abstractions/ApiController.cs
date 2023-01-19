using Microsoft.AspNetCore.Mvc;

namespace OlmServer.Presentation.Abstractions
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}

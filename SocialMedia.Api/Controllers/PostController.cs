using Microsoft.AspNetCore.Mvc;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("hola");
        }
    }
}

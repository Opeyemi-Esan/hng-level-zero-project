using Microsoft.AspNetCore.Mvc;

namespace HngLevelZeroProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet("get_allinfo")]
        public IActionResult GetInfo()
        {
            var response = new MyInfo
            {
                Email = "tolulopejossy@gmail.com",  
                CurrentTime = DateTime.UtcNow,  
                GitHubUrl = "https://github.com/Opeyemi-Esan/hng-level-zero-project"
            };

            return Ok(response);
        }
    }
}

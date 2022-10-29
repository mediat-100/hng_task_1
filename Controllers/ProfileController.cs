using hng_task_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace hng_task_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var user = new Profile()
            {
                slackUsername = "Tomz",
                backend = true,
                age = 24,
                bio = "Backend Engineer"
            };

            return Ok(user);
        }
    }
}

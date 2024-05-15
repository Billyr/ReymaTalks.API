using Microsoft.AspNetCore.Mvc;

namespace ReymaTalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

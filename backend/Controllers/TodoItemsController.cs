using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoItemsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("This is my default action...");
        }
    }
}

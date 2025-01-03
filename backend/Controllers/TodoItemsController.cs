using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoItemsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("get all todos");
        }

        [HttpGet("{id}")]
        public IActionResult GetTodoItemById([FromQuery] int id)
        {
            return Ok("get todo item by id");
        }

        [HttpPost]
        public IActionResult CreateTodo([FromBody] string title)
        {
            return Ok("Todo Item has been created successfully!");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTodoItem([FromQuery] int id, [FromBody] TodoItem todoItem)
        {
            return Ok("Todo has been updated successfully!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTodoItem([FromQuery] int id)
        {
            return Ok("Todo with ${id} has been deleted!");
        }
    }
}

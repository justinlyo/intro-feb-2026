using Microsoft.AspNetCore.Mvc;

namespace TodoListWeek1.Controllers;

public class TodosController : ControllerBase
{
    [HttpGet("/todos")]
    public async Task<ActionResult> GetAllTodos()
    {
        return Ok(new List<string> { "clean the garage", "take trash out" });
    }
}

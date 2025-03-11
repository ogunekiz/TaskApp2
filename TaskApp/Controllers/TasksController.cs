using Microsoft.AspNetCore.Mvc;
using TaskApp.Models;

namespace TaskApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private static readonly List<TaskItem> tasks = new()
    {
        new TaskItem { Id = 1, Title = "Alışveriş yap", IsCompleted = false },
        new TaskItem { Id = 2, Title = "Rapor hazırla", IsCompleted = true },
        new TaskItem { Id = 3, Title = "Spor yap", IsCompleted = false },
        new TaskItem { Id = 4, Title = "Kitap oku", IsCompleted = true },
        new TaskItem { Id = 5, Title = "Koşu yap", IsCompleted = true }
    };

        [HttpGet]
        public ActionResult<IEnumerable<TaskItem>> GetTasks()
        {
            return Ok(tasks);
        }
    }
}

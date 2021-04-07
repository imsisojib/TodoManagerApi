using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoManagerApi.TodoData;

namespace TodoManagerApi.Controllers
{
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoData _todoData;

        public TodosController(ITodoData todoData)
        {
            _todoData = todoData;

        }

        [HttpGet]
        //[Route("api/[controller]")], by default create route from method name...here it would be: api/todos
        [Route("api/all_todos")]
        public IActionResult GetTodos()
        {
            return Ok(_todoData.GetTodos());
        }
    }
}

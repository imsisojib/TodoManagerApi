using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoManagerApi.Models;
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

        [HttpGet]
        //[Route("api/[controller]")], by default create route from method name...here it would be: api/todos
        [Route("api/single_todo/{id}")]
        public IActionResult GetSingleTodo(Guid id)
        {
            var todo = _todoData.GetTodo(id);
            if (todo == null)
            {
                return NotFound($"Todo id:= {id}, not found.");
            }else
            {
                return Ok(todo);
            }
           
        }

        [HttpPost]
        //[Route("api/[controller]")], by default create route from method name...here it would be: api/todos
        [Route("api/add_todo")]
        public IActionResult AddTodo(Todo todo)
        {
            todo.Id = Guid.NewGuid();
            _todoData.AddTodo(todo);
            /*return Created(HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                todo.Id,todo);*/
            //it will create and redirect to get_todo api

            //though we do not used Controller...so we have to do it manually.
            return Created(HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host + "/api/single_todo" + "/" +
                todo.Id, todo);

        }

        [HttpDelete]
        //[Route("api/[controller]")], by default create route from method name...here it would be: api/todos
        [Route("api/delete_todo/{id}")]
        public IActionResult DeleteTodo(Guid id)
        {
            var todo = _todoData.GetTodo(id);
            if (todo != null)
            {
                _todoData.DeleteTodo(todo);
                return Ok("Todo is deleted.");
            }
            else
            {
                return NotFound($"Todo id:= {id}, not found.");
            }
        }

        [HttpPatch] //for update
        //[Route("api/[controller]")], by default create route from method name...here it would be: api/todos
        [Route("api/update_todo")]
        public IActionResult UpdateTodo(Todo todo)
        {
            var existingTodo = _todoData.GetTodo(todo.Id);
            if (existingTodo != null)
            {
                return Ok(_todoData.UpdateTodo(todo));
            }
            else
            {
                return NotFound($"Todo is not found.");
            }
        }

    }
}

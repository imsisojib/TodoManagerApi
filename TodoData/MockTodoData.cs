using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoManagerApi.Models;

namespace TodoManagerApi.TodoData
{
    public class MockTodoData : ITodoData
    {

        private List<Todo> todos = new List<Todo>()
        {
            new Todo()
            {
                Id = Guid.NewGuid(),
                Tittle = "Todo 1",
                Description = "This is first todo."
            },
            new Todo()
            {
                Id = Guid.NewGuid(),
                Tittle = "Todo 2",
                Description = "This is second todo."
            }
        };

        //Test Purpose to check api
        public void AddTodo(Todo todo)
        {
            todos.Add(todo);
        }

        public void DeleteTodo(Todo todo)
        {
            todos.Remove(todo);
        }

        public Todo GetTodo(Guid id)
        {
            return todos.SingleOrDefault(x => x.Id == id);
        }

        public List<Todo> GetTodos()
        {
            return todos;
        }

        public Todo UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}

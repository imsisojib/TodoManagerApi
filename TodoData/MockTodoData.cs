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
        public Todo AddTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(Guid id)
        {
            throw new NotImplementedException();
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

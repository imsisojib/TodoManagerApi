using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoManagerApi.Models;

namespace TodoManagerApi.TodoData
{
    public class MockTodoData : ITodoData
    {
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
            throw new NotImplementedException();
        }

        public Todo UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}

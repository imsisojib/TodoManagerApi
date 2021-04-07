using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoManagerApi.Models;

namespace TodoManagerApi.TodoData
{
    public interface ITodoData
    {
        List<Todo> GetTodos();

        Todo GetTodo(Guid id);

        void AddTodo(Todo todo);

        void DeleteTodo(Todo todo);

        Todo UpdateTodo(Todo todo); 
    }
}

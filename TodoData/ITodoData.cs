using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoManagerApi.Models;

namespace TodoManagerApi.TodoData
{
    interface ITodoData
    {
        List<Todo> GetTodos();

        Todo GetTodo(Guid id);

        Todo AddTodo(Todo todo);

        void DeleteTodo(Todo todo);

        Todo UpdateTodo(Todo todo); 
    }
}

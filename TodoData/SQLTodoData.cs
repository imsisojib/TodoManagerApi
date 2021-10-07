using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoManagerApi.Models;

namespace TodoManagerApi.TodoData
{
    public class SQLTodoData : ITodoData
    {
        //for database context
        private TodoContext _todoDbContext; //our db will be called by _todoDbContext

	public SQLTodoData(TodoContext todoContext)
        {
            _todoDbContext = todoContext;
        }

        public void AddTodo(Todo todo)
        {
            todo.Id = Guid.NewGuid();
            _todoDbContext.Todos.Add(todo);
            _todoDbContext.SaveChanges();

        
        }

        public void DeleteTodo(Todo todo)
        {
            _todoDbContext.Todos.Remove(todo);
            _todoDbContext.SaveChanges();

           /* Or,
	
            Var existingTodo = _todoDbContext.Todos.Find(todo);
            if (existingTodo != null)
            {
                _todoDbContext.Todos.Remove(existingTodo);
                _todoDbContext.SaveChanges();
            }*/
        }

        public Todo GetTodo(Guid id)
        {
            return _todoDbContext.Todos.Find(id);
               /* Or,
	        return _todoDbContext.Todos.SingleOrDefaults(x => x.Id == id);*/
        }

        public List<Todo> GetTodos()
        {
            return _todoDbContext .Todos.ToList();

           /* List<Todo> testTodos = new List<Todo>();
            Todo todoo = new Todo();
            todoo.Id = new Guid();
            todoo.Tittle = "Testing Todo";
            todoo.Description = "For testing from IIS server.";
            testTodos.Add(todoo);

            return testTodos;*/
        }

        public Todo UpdateTodo(Todo todo)
        {
            var existingTodo = _todoDbContext.Todos.Find(todo.Id);
            if (existingTodo != null)
            {
                /*_todoDbContext.Todos.Update(todo);
                _todoDbContext.SaveChanges();*/

                //Or,
                existingTodo.Tittle = todo.Tittle;
                existingTodo.Description = todo.Description;
                _todoDbContext.Todos.Update(existingTodo);
                _todoDbContext.SaveChanges();
               
            }

            return todo;
        }
    }

}

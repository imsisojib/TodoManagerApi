using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoManagerApi.Models
{
	public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options):base(options)
        { }

        public DbSet<Todo>  Todos { get; set; }


        //initially seed data into table
        //each enitity can be added in this below method.
        //after updating: add-migration, updated-database then done.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.OnModelCreating(modelBuilder);

            builder.Entity<Todo>().HasData(
                    new Todo { 
                        Id = new Guid(),
                        Tittle = "Demo Tittle",
                        Description = "Demo Description Here"
                    }
                ) ;
        }

    }

}

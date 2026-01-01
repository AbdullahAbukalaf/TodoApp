using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Abstractions;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Infrastructure.Repositories
{
    internal class ToDoRepository : ITodoRepository
    {
        public Task AddAsync(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public Task<List<TodoItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

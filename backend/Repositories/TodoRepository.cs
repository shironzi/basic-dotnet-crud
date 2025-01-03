using System;
using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return await _context.Todos.ToListAsync();
        }

        public async Task<TodoItem> GetByIdAsync(int id)
        {
            var item = await _context.Todos.FindAsync(id);
            if (item == null)
            {
                throw new KeyNotFoundException($"TodoItem with id {id} not found.");
            }
            return item;
        }

        public async Task AddAsync(TodoItem todoItem)
        {
            await _context.Todos.AddAsync(todoItem);
        }

        public void Update(TodoItem todoItem)
        {
            _context.Todos.Update(todoItem);
        }

        public void Delete(TodoItem todoItem)
        {
            _context.Todos.Remove(todoItem);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
using System;
using System.Net.Http.Headers;
using backend.Models;

namespace backend.Repositories;

public interface ITodoRepository
{
    Task<IEnumerable<TodoItem>> GetAllAsync();
    Task<TodoItem> GetByIdAsync(int id);
    Task AddAsync(TodoItem todoItem);
    void Update(TodoItem todoItem);
    void Delete(TodoItem todoItem);
    Task SaveChangesAsync();
}

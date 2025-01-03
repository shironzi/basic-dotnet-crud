using System;
using backend.Data;

namespace backend.Models;

public enum TodoStatus
{
    Done,
    Pending,
    Working
}


public class TodoItem : BaseModel
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required TodoStatus IsComplete { get; set; } = TodoStatus.Pending;
}

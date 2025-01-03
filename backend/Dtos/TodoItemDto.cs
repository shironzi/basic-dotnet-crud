using System;

namespace backend.Dtos;

public enum TodoStatus
{
    Done,
    Pending,
    Working
}

public class TodoItemDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required TodoStatus IsComplete { get; set; } = TodoStatus.Pending;
}

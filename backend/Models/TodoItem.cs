using System;

namespace backend.Models;

public class TodoItem
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string IsComplete { get; set; }
}

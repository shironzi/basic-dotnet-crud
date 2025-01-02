using System;
using backend.Data;

namespace backend.Models;

public class TodoItem : BaseModel
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string IsComplete { get; set; }
}
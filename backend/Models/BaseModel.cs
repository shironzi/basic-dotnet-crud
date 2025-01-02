using System;

namespace backend.Data
{
    public abstract class BaseModel
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

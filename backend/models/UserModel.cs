using System.ComponentModel.DataAnnotations;

public sealed class User : BaseEntityModel
{

    [StringLength(50)]
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}
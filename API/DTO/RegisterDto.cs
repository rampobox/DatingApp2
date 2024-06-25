using System.ComponentModel.DataAnnotations;

namespace API.DTO;

public class RegisterDto 
{
    [Required]
    [MaxLength(50)]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }
}
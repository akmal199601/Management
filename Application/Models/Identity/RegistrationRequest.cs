using System.ComponentModel.DataAnnotations;

namespace Application.Models.Identity;

public class RegistrationRequest
{
    [Required] public string FirsName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string UserName { get; set; }
    [Required] public string Password { get; set; }
}
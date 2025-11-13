using System.ComponentModel.DataAnnotations;

namespace VotoSeguro.DTOs;

public class LoginDto
{
    [Required(ErrorMessage = "El email es requerido")]
    [EmailAddress(ErrorMessage = "Ingrese el email valido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "El password es requerido")]

    public string Password { get; set; } = string.Empty;
}
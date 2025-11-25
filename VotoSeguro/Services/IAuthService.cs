using VotoSeguro.Models;
using VotoSeguro.DTOs;


namespace VotoSeguro.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDto> Register(RegisterDto dto);
        Task<AuthResponseDto> Login(LoginDto dto);
        Task<User?> GetUserById(string id);
        Task<User?> GetUserByEmail(string email);
        string GenerateJwtToken(User user);
    }
}


using Application.Models.Identity;

namespace Application.Contracts.Identity;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthRequest request);
    Task<RegistrationRequest> Register(RegistrationRequest request);
}
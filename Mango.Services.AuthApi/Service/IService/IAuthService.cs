using Mango.Services.AuthApi.Model.DTO;

namespace Mango.Services.AuthApi.Service.IService
{
    public interface IAuthService
    {
        Task<bool> AssignRole(string email, string v);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<string?> Register(RegistrationRequestDTO model);
        
    }
}

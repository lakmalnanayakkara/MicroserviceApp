using Mango.Services.AuthApi.Model.DTO;

namespace Mango.Services.AuthApi.Service.IService
{
    public class IAuthService
    {
        internal async Task<bool> AssignRole(string email, string v)
        {
            throw new NotImplementedException();
        }

        internal async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        internal async Task<string?> Register(RegistrationRequestDTO model)
        {
            throw new NotImplementedException();
        }
    }
}

using Mango.Web.Models;
using Mango.Web.Models.Auth;

namespace Mango.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDTO?> LoginAsync(LoginRequestDTO loginRequestDto);
        Task<ResponseDTO?> RegisterAsync(RegistrationRequestDTO registrationRequestDto);
        Task<ResponseDTO?> AssignRoleAsync(RegistrationRequestDTO registrationRequestDto);
    }
}

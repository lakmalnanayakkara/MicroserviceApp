using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthApi.Model
{
    public class ApplicationUser :IdentityUser
    {
        public string Name {  get; set; }
    }
}

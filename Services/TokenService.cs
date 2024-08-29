using DI.Services.Interfaces;

namespace DI.Services
{
    public class TokenService : ITokenService
    {
        public string GeraToken()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}

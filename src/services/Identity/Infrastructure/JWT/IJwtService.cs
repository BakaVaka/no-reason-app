using System.Security.Claims;

namespace Identity.Infrastructure.JWT;

public interface IJwtService<T>
{
    public string CreateToken(T identity);
    public ClaimsPrincipal GetClaims(string token);
}

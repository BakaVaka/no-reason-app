using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Identity.Infrastructure.JWT;

public class JwtService<T> : IJwtService<T>
{
    private readonly ClaimsProvider<T> _claimsProvider;
    private readonly JwtAuthOptions _authOptions;

    public JwtService(ClaimsProvider<T> claimsProvider, JwtAuthOptions authOptions) {
        _claimsProvider = claimsProvider;
        _authOptions = authOptions;
    }

    public string CreateToken(T identity) {

        var principal = _claimsProvider.GetClaims(identity);

        var now = DateTime.UtcNow;
        // создаем JWT-токен
        var tpken = new JwtSecurityToken(
            issuer : _authOptions.Issuer,
            audience: _authOptions.Audience,
            notBefore: now,
            claims: principal.Claims,
            expires: now + _authOptions.AccessTokenLifetime);

        var handler = new JwtSecurityTokenHandler();
        handler.CreateJwtSecurityToken();

    }
    public ClaimsPrincipal GetClaims(string token) {

    }
}

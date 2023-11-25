using Microsoft.IdentityModel.Tokens;

namespace Identity.Infrastructure.JWT;

public class JwtAuthOptions {
    public string Issuer { get; init; }
    public string Audience { get; init; }
    public TimeSpan AccessTokenLifetime { get; init; }
    public TimeSpan RefreshTokenLifetime { get; init; }
    public SecurityKey SigningKey { get; init; }
    public string SigningAlgorithm { get; init; }
    public SecurityKey SecurityKey { get; init; }
    public string SecurityAlgorithm { get; init; }

}

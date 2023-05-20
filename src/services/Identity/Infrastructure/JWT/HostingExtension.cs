using System.Security.Claims;

using Identity.Models;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Identity.Infrastructure.JWT;

public static class HostingExtension {
    public static IServiceCollection AddJwtAuthentication(
        this IServiceCollection services, JwtAuthOptions options) {

        services.AddSingleton(options);
        services.AddSingleton(new ClaimsProvider<User>((u) => {
            var claims = new List<Claim>
            {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, u.Id.ToString()),
                    new Claim("email", u.Email),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, u.Role.Name),
            };
            var identity = new ClaimsIdentity(claims);
            return new ClaimsPrincipal(identity);
        }));

        services.AddAuthentication(options => {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(o => {
            o.TokenValidationParameters = new TokenValidationParameters() {
                ValidIssuer = options.Issuer,
                ValidAudience = options.Audience,
                IssuerSigningKey = options.SigningKey,
                TokenDecryptionKey = options.SecurityKey,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
            };
        });

        return services;
    }
}

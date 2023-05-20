using System.Security.Claims;

namespace Identity.Infrastructure.JWT;

public class ClaimsProvider<T> {
    private readonly Func<T, ClaimsPrincipal> _claimsFactory;
    public ClaimsProvider(Func<T, ClaimsPrincipal> claimsFactory) {
        _claimsFactory = claimsFactory;
    }
    public ClaimsPrincipal GetClaims(T identity) => _claimsFactory(identity);
}

using Identity.Services.Users;

using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Auth;

[ApiController, Route("api/identity/auth")]
public class AuthController : ControllerBase {

    private IUserService _userService;

    public AuthController(IUserService userService) {
        _userService = userService;
    }

    [HttpPost("login")]
    public Task<IActionResult> Login(LoginRequest loginRequest,
                                     CancellationToken cancellationToken = default) {
        throw new NotImplementedException();
    }
}


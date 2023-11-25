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
    public async Task<IActionResult> Login(LoginRequest loginRequest, CancellationToken cancellationToken = default) {
        try {
            var response = await _userService.Login(loginRequest, cancellationToken);
            if( response is not null ) {
                return Ok(response);
            }
        }
        catch( Exception ex ) {
            return StatusCode(500, new { Error = $"{ex.Message}" });
        }
        return StatusCode(401, new { Error = "Auth fail" });
    }
}


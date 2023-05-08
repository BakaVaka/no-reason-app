namespace Identity.Services.Users;

public class UserService : IUserService {
    public Task<LoginResponce> Login(LoginRequest loginRequest, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<RegistrationResponce> Register(RegistrationRequest registrationRequest, CancellationToken cancellationToken = default) => throw new NotImplementedException();
}

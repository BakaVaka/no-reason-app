namespace Identity.Services.Users;

public interface IUserService {
    public Task<LoginResponce> Login(LoginRequest loginRequest, CancellationToken cancellationToken = default);
    public Task<RegistrationResponce> Register(RegistrationRequest registrationRequest, CancellationToken cancellationToken = default);

}

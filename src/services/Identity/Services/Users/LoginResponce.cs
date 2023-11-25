namespace Identity.Services.Users;

public class LoginResponce {
    public UserInfo UserInfo { get; set; }
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
}

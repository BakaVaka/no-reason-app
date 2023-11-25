namespace Identity.Services.Users;

public class UserInfo {
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string[] Permissions { get; set; }
}

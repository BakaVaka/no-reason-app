namespace Identity.Models;

/// <summary>
/// Пользователь
/// </summary>
public class User {
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string? Phone { get; set; }
    public string PasswordHash { get; set; }
    public bool EmailConfirmed { get; set; }
    public bool PhoneConfirmed { get; set; }
    public int LoginFailCount { get; set; }
    public bool AccessBlocked { get; set; }
    public Role Role { get; set; }
}
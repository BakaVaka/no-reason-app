namespace Identity.Models;

/// <summary>
/// Роль
/// </summary>
public class Role {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Permission> Permissions { get; } = new List<Permission>();
}

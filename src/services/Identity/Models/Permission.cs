namespace Identity.Models;

/// <summary>
/// Разрешение
/// </summary>
public class Permission {
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Role> Roles { get; } = new List<Role>();
}
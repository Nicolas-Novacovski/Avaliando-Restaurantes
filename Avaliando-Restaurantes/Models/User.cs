using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public enum UserRole { User, Admin }

public class User
{
    public int IdPerson { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public UserRole Role { get; set; } = UserRole.User;

    // Propriedades de Navegação
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
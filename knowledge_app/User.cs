using System;
using System.Collections.Generic;

namespace knowledge_app;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? StatusId { get; set; }

    public int? FacultyId { get; set; }

    public virtual Faculty? Faculty { get; set; }

    public virtual Status? Status { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}

using System;
using System.Collections.Generic;

namespace kicksharing.Models;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public int IdRole { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly RegistrationDate { get; set; }

    public string Pass { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}

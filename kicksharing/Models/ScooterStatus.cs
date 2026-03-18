using System;
using System.Collections.Generic;

namespace kicksharing.Models;

public partial class ScooterStatus
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Scooter> Scooters { get; set; } = new List<Scooter>();
}

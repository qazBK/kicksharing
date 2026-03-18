using System;
using System.Collections.Generic;

namespace kicksharing.Models;

public partial class TripStatus
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}

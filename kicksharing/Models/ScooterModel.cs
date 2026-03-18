using System;
using System.Collections.Generic;

namespace kicksharing.Models;

public partial class ScooterModel
{
    public int Id { get; set; }

    public string ModelName { get; set; } = null!;

    public int MaxSpeed { get; set; }

    public int RangeKm { get; set; }

    public int PowerWatt { get; set; }

    public int WeightKg { get; set; }

    public int PricePerMinute { get; set; }

    public virtual ICollection<Scooter> Scooters { get; set; } = new List<Scooter>();
}

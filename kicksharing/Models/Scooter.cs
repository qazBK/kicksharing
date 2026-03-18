using System;
using System.Collections.Generic;

namespace kicksharing.Models;

public partial class Scooter
{
    public int Id { get; set; }

    public string SerialNumber { get; set; } = null!;

    public int IdModel { get; set; }

    public DateOnly BuyDate { get; set; }

    public int CurrentMileage { get; set; }

    public int CurrentBattery { get; set; }

    public string CurrentLocation { get; set; } = null!;

    public int IdStatus { get; set; }

    public virtual ScooterModel IdModelNavigation { get; set; } = null!;

    public virtual ScooterStatus IdStatusNavigation { get; set; } = null!;

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}

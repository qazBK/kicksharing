using System;
using System.Collections.Generic;

namespace kicksharing.Models;

public partial class Trip
{
    public int Id { get; set; }

    public int IdScooters { get; set; }

    public int IdUser { get; set; }

    public DateOnly StartDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public DateOnly? EndDate { get; set; }

    public TimeOnly? EndTime { get; set; }

    public int? DistanceMeters { get; set; }

    public int? DurationMinutes { get; set; }

    public int? Cost { get; set; }

    public int IdTripStatus { get; set; }

    public int? IdPaymentStatus { get; set; }

    public virtual PaymentStatus? IdPaymentStatusNavigation { get; set; }

    public virtual Scooter IdScootersNavigation { get; set; } = null!;

    public virtual TripStatus IdTripStatusNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}

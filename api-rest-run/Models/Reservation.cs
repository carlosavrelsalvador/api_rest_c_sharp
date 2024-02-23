using System;
using System.Collections.Generic;

namespace api_rest_run.Models;

public partial class Reservation
{
    public string? DurationInMinutes { get; set; }

    public DateTime? DateTimeStart { get; set; }

    public DateTime? DateTimeEnd { get; set; }

    public decimal? TotalCost { get; set; }

    public string? IsPaid { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? SlotId { get; set; }

    public int VehicleId { get; set; }
}

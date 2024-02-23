using System;
using System.Collections.Generic;

namespace api_rest_run.Models;

public partial class Slot
{
    public string? Floor { get; set; }

    public string SlotNumber { get; set; } = null!;

    public string? Free { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

using System;
using System.Collections.Generic;

namespace api_rest_run.Models;

public partial class Inventory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Quantity { get; set; }
}

using System;
using System.Collections.Generic;

namespace api_rest_run.Models;

public partial class Vehicle
{
    public string Plate { get; set; } = null!;

    public string? Name { get; set; }

    public string? TypeCar { get; set; }

    public string? Model { get; set; }

    public string? Brand { get; set; }

    public string? Year { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

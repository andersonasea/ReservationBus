using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class Destination
{
    public int Id { get; set; }

    public string LibDestination { get; set; } = null!;

    public string IdDestination { get; set; } = null!;
}

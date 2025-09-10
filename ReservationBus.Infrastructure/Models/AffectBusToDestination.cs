using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class AffectBusToDestination
{
    public int Id { get; set; }

    public string LibAffectation { get; set; } = null!;

    public DateTime? Periode { get; set; }
}

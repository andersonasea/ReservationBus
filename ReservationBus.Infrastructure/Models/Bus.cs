using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class Bus
{
    public int Id { get; set; }

    public string LibBus { get; set; } = null!;

    public string IdSociety { get; set; } = null!;

    public string IdCategory { get; set; } = null!;

    public string? IdDestionation { get; set; }
}

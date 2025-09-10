using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class Place
{
    public int Id { get; set; }

    public string LibPlace { get; set; } = null!;

    public string IdBus { get; set; } = null!;
}

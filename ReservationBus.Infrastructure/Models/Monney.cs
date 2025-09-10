using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class Monney
{
    public int Id { get; set; }

    public string LibMonney { get; set; } = null!;

    public string IdMonney { get; set; } = null!;
}

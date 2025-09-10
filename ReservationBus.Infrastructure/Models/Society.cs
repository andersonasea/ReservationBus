using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class Society
{
    public int Id { get; set; }

    public string LibSociety { get; set; } = null!;

    public string Picture { get; set; } = null!;

    public string IdSociety { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class AffectationRole
{
    public int Id { get; set; }

    public string Idrole { get; set; } = null!;

    public string Iduser { get; set; } = null!;
}

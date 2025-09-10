using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class TypeUser
{
    public int Id { get; set; }

    public string LibTypeUser { get; set; } = null!;

    public string IdTypeUser { get; set; } = null!;
}

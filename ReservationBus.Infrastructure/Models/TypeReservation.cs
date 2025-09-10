using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class TypeReservation
{
    public int Id { get; set; }

    public string LibTypeReservation { get; set; } = null!;

    public string IdTypeReservation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public int Mount { get; set; }

    public string Monney { get; set; } = null!;

    public DateTime DateDepart { get; set; }

    public string IdUser { get; set; } = null!;

    public string IdTypeReservation { get; set; } = null!;
}

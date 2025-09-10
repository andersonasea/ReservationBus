using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Email { get; set; }

    public string IdTypeUser { get; set; } = null!;
}

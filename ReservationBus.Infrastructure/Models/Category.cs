using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class Category
{
    public int Id { get; set; }

    public string LibCategory { get; set; } = null!;

    public string IdCategory { get; set; } = null!;
}

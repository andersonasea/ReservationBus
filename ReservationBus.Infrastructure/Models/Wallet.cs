using System;
using System.Collections.Generic;

namespace ReservationBus.Infrastructure.Models;

public partial class Wallet
{
    public int Id { get; set; }

    public string LibWallet { get; set; } = null!;

    public string IdWallet { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Tourism.Models;

public partial class Traveler
{
    public int TravelerId { get; set; }

    public int? UserId { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? Image { get; set; }

    public long? PhoneNumber { get; set; }

    public virtual User? User { get; set; }
}

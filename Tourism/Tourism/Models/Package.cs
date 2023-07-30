using System;
using System.Collections.Generic;

namespace Tourism.Models;

public partial class Package
{
    public int PackageId { get; set; }

    public string? PackageName { get; set; }

    public string? Region { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}

using System;
using System.Collections.Generic;

namespace Tourism.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public byte[]? Password { get; set; }

    public byte[]? HashKey { get; set; }

    public string? EmailId { get; set; }

    public string? Role { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<TravelAgent> TravelAgents { get; set; } = new List<TravelAgent>();

    public virtual ICollection<Traveler> Travelers { get; set; } = new List<Traveler>();
}

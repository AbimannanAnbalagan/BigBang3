using System;
using System.Collections.Generic;

namespace Tourism.Models;

public partial class TravelAgent
{
    public int AgentId { get; set; }

    public int? UserId { get; set; }

    public string? TravelAgency { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? Image { get; set; }

    public long? PhoneNumber { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual User? User { get; set; }
}

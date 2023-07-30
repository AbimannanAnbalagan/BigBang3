using System;
using System.Collections.Generic;

namespace Tourism.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? UserId { get; set; }

    public int? PackageId { get; set; }

    public int? AgentId { get; set; }

    public string? BoardingLocation { get; set; }

    public int? NoOfPerson { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Date { get; set; }

    public virtual TravelAgent? Agent { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual Package? Package { get; set; }

    public virtual User? User { get; set; }
}

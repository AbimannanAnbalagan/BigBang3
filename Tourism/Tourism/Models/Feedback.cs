using System;
using System.Collections.Generic;

namespace Tourism.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public string? Feedback1 { get; set; }

    public int? BookingId { get; set; }

    public int? Rating { get; set; }

    public virtual Booking? Booking { get; set; }
}

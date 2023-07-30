using System;
using System.Collections.Generic;

namespace Tourism.Models;

public partial class ContactU
{
    public int ContactUsId { get; set; }

    public string? Message { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }
}

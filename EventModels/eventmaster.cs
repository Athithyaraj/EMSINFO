using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMSINFO.EventModels;

public partial class Eventmaster
{
    public int id { get; set; }
    [Required]
    public string event_name { get; set; } = null!;
    public string? event_description { get; set; }
}

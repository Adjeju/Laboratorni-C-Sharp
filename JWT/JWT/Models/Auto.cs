using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JWT.Models
{
    public partial class Auto
    {
        public int Code { get; set; }
        public string Mark { get; set; }
        public string Color { get; set; }
        public double? Price { get; set; }
        public int? Year { get; set; }
        public double? Volume { get; set; }
    }
}

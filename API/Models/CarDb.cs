using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public partial class CarDb
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Color { get; set; }
        public int? Year { get; set; }
        public int? Price { get; set; }
        public double? Volume { get; set; }
    }
}

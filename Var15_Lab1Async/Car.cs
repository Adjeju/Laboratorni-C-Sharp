namespace Var15_Lab1Async
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int Id { get; set; }

        [StringLength(15)]
        public string Mark { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

        public double? Price { get; set; }

        public int? Year { get; set; }

        public double? Volume { get; set; }
    }
}

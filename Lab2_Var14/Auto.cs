namespace Lab2_Var14
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Auto")]
    public partial class Auto
    {
        [Key]
        public int Code { get; set; }

        [StringLength(10)]
        public string Mark { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        public double? Price { get; set; }

        [StringLength(10)]
        public string Year { get; set; }

        public double? Volume { get; set; }
    }
}

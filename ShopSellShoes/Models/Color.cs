namespace ShopSellShoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Color
    {
        public int ColorID { get; set; }

        [Column("Color")]
        [StringLength(50)]
        public string Color1 { get; set; }
    }
}

namespace ShopSellShoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Size
    {
        public int SizeID { get; set; }

        [Column("Size")]
        [StringLength(50)]
        public string Size1 { get; set; }
    }
}

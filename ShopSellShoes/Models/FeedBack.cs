namespace ShopSellShoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FeedBack
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FeedBackID { get; set; }

        public int? UserID { get; set; }

        public int? ProductID { get; set; }

        public string Comment { get; set; }
    }
}

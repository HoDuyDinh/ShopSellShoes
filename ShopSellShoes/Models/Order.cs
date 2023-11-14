namespace ShopSellShoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public int? UserID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(50)]
        public string Quantity { get; set; }

        public DateTime? OrderDate { get; set; }

        public string Status { get; set; }

        public int? CategoryID { get; set; }

        public int? ColorID { get; set; }

        public int? SizeID { get; set; }
    }
}

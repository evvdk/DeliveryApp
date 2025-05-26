namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order Set")]
    public partial class Order_Set
    {
        [Column("Order ID")]
        public int? Order_ID { get; set; }

        [Column("Client Login")]
        [StringLength(30)]
        public string Client_Login { get; set; }

        [Column("Order Status")]
        public int? Order_Status { get; set; }

        [Key]
        [Column("Dish ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dish_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Count { get; set; }

        [Column("Dish Name")]
        [StringLength(50)]
        public string Dish_Name { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public int? Mass { get; set; }

        public int? Calories { get; set; }
    }
}

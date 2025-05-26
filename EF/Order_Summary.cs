namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order Summary")]
    public partial class Order_Summary
    {
        [Key]
        [Column("Order ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        [Key]
        [Column("Producer ID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Producer_ID { get; set; }

        [Key]
        [Column("Producer Name", Order = 2)]
        [StringLength(30)]
        public string Producer_Name { get; set; }

        [Column("Calories Summary")]
        public int? Calories_Summary { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bill { get; set; }

        [Column("Dish Count")]
        public int? Dish_Count { get; set; }
    }
}

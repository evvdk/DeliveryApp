namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dishes Order")]
    public partial class Dishes_Order
    {
        [Key]
        [Column("Order ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        [Key]
        [Column("Dish ID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dish_ID { get; set; }

        public int Count { get; set; }

        public virtual Dish Dish { get; set; }

        public virtual Order Order { get; set; }
    }
}

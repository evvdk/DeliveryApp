namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producer Dishes")]
    public partial class Producer_Dishes
    {
        [Column("Producer ID")]
        public int? Producer_ID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [Key]
        [Column("Dish ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dish_ID { get; set; }

        [Key]
        [Column("Dish Name", Order = 1)]
        [StringLength(50)]
        public string Dish_Name { get; set; }

        [Key]
        [Column("Dish Cost", Order = 2, TypeName = "money")]
        public decimal Dish_Cost { get; set; }
    }
}

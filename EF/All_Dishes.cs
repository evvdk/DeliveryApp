namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("All Dishes")]
    public partial class All_Dishes
    {
        [Key]
        [Column("Dish ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dish_ID { get; set; }

        [Column("Producer ID")]
        public int? Producer_ID { get; set; }

        [Key]
        [Column("Dish Name", Order = 1)]
        [StringLength(50)]
        public string Dish_Name { get; set; }

        public byte[] Image { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal Cost { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Calories { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mass { get; set; }

        [Column("Producer Name")]
        [StringLength(30)]
        public string Producer_Name { get; set; }
    }
}

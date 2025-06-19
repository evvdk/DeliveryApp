namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dish All Info")]
    public partial class Dish_All_Info
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column("Producer ID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Producer_ID { get; set; }

        [Column("Producer Name")]
        [StringLength(30)]
        public string Producer_Name { get; set; }

        [Key]
        [Column("Dish Name", Order = 2)]
        [StringLength(50)]
        public string Dish_Name { get; set; }

        public byte[] Image { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal Cost { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Calories { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column("Ingredient Name")]
        [StringLength(30)]
        public string Ingredient_Name { get; set; }
    }
}

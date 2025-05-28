namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dish")]
    public partial class Dish
    {
        public int ID { get; set; }

        [Column("Producer ID")]
        public int Producer_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public byte[] Image { get; set; }

        [Column("Image Type")]
        [StringLength(50)]
        public string Image_Type { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int Calories { get; set; }

        public int Mass { get; set; }

        public byte? Visible { get; set; }
    }
}

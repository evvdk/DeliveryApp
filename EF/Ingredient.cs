namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ingredient")]
    public partial class Ingredient
    {
        [Key]
        [Column("Ingredient ID")]
        public int Ingredient_ID { get; set; }

        [Column("Ingredient Name")]
        [Required]
        [StringLength(30)]
        public string Ingredient_Name { get; set; }
    }
}

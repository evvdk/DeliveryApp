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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            Dishes_Order = new HashSet<Dishes_Order>();
            Ingredient = new HashSet<Ingredient>();
        }

        public int ID { get; set; }

        [Column("Producer ID")]
        public int Producer_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public byte[] Image { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int Calories { get; set; }

        public int Mass { get; set; }

        public byte? Visible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dishes_Order> Dishes_Order { get; set; }

        public virtual Producer Producer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredient> Ingredient { get; set; }
    }
}

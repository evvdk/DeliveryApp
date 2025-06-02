namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producer")]
    public partial class Producer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producer()
        {
            Dish = new HashSet<Dish>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Login { get; set; }

        [Required]
        [MaxLength(32)]
        public byte[] Password { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public short? Grade { get; set; }

        public int Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dish> Dish { get; set; }

        public virtual Room Room1 { get; set; }
    }
}

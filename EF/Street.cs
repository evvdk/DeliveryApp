namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Street")]
    public partial class Street
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Street()
        {
            Building = new HashSet<Building>();
        }

        public int ID { get; set; }

        [Column("Street")]
        [Required]
        [StringLength(50)]
        public string Street1 { get; set; }

        public int District { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building> Building { get; set; }

        public virtual District District1 { get; set; }
    }
}

namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courier")]
    public partial class Courier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Courier()
        {
            Order = new HashSet<Order>();
        }

        public int ID { get; set; }

        [Column("First Name")]
        [Required]
        [StringLength(30)]
        public string First_Name { get; set; }

        [Column("Second Name")]
        [Required]
        [StringLength(30)]
        public string Second_Name { get; set; }

        [Column("Last Name")]
        [Required]
        [StringLength(30)]
        public string Last_Name { get; set; }

        [Required]
        [StringLength(12)]
        public string Phone { get; set; }

        [Column("Passport Number")]
        [Required]
        [StringLength(10)]
        public string Passport_Number { get; set; }

        [Column("Work Book")]
        [Required]
        [StringLength(7)]
        public string Work_Book { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}

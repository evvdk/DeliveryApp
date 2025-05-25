namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Dishes_Order = new HashSet<Dishes_Order>();
        }

        public int ID { get; set; }

        [Column("Client ID")]
        public int Client_ID { get; set; }

        [Column("Client Address ID")]
        public int Client_Address_ID { get; set; }

        public int? Courier { get; set; }

        [Column("Ordered At")]
        public DateTime? Ordered_At { get; set; }

        [Column("Complited At")]
        public DateTime? Complited_At { get; set; }

        public int Status { get; set; }

        [Column("Order Grade")]
        public int? Order_Grade { get; set; }

        public virtual Courier Courier1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dishes_Order> Dishes_Order { get; set; }

        public virtual Status Status1 { get; set; }
    }
}

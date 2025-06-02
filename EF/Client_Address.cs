namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client Address")]
    public partial class Client_Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client_Address()
        {
            Order = new HashSet<Order>();
        }

        public int ID { get; set; }

        public int Client { get; set; }

        public int Room { get; set; }

        public byte? Active { get; set; }

        public virtual Client Client1 { get; set; }

        public virtual Room Room1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}

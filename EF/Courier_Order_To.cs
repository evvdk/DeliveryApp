namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courier Order To")]
    public partial class Courier_Order_To
    {
        public int? ID { get; set; }

        [Key]
        [Column("Order ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        [Key]
        [Column("Client Login", Order = 1)]
        [StringLength(30)]
        public string Client_Login { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(10)]
        public string Building { get; set; }

        public int? Floor { get; set; }

        [StringLength(10)]
        public string Room { get; set; }
    }
}

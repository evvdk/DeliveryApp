namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address By Login")]
    public partial class Address_By_Login
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column("Client ID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(6)]
        public string Building { get; set; }

        [StringLength(5)]
        public string Room { get; set; }

        public byte? Active { get; set; }
    }
}

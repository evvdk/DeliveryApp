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
        public int ID { get; set; }

        [Column("Client Login")]
        [Required]
        [StringLength(30)]
        public string Client_Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Region { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string District { get; set; }

        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        [Required]
        [StringLength(10)]
        public string Building { get; set; }

        public int? Floor { get; set; }

        [Required]
        [StringLength(10)]
        public string Room { get; set; }

        public byte? Active { get; set; }
    }
}

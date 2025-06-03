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
        [Column("Client Login", Order = 0)]
        [StringLength(30)]
        public string Client_Login { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public byte[] Password { get; set; }

        [Key]
        [Column("Active Account", Order = 2)]
        public byte Active_Account { get; set; }

        [Key]
        [Column("Address ID", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Address_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Region { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string City { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string District { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Street { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string Building { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string Room { get; set; }

        [Column("Active Address")]
        public byte? Active_Address { get; set; }
    }
}

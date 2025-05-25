namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [Key]
        [StringLength(30)]
        public string Login { get; set; }

        [Required]
        [StringLength(64)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime Created { get; set; }

        [Column("Active Account")]
        public byte Active_Account { get; set; }
    }
}

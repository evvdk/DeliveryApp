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
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Login { get; set; }

        [Required]
        [StringLength(60)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int? Grade { get; set; }

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
    }
}

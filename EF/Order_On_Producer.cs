namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order On Producer")]
    public partial class Order_On_Producer
    {
        [Key]
        [Column("Order ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        [Column("Producer ID")]
        public int? Producer_ID { get; set; }

        [Column("Producer Name")]
        [StringLength(30)]
        public string Producer_Name { get; set; }
    }
}

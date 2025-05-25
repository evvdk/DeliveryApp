namespace DeliveryApp.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Order")]
    public partial class Order
    {
        public int ID { get; set; }

        [Column("Client Login")]
        [Required]
        [StringLength(30)]
        public string Client_Login { get; set; }

        [Column("Client Address ID")]
        public int Client_Address_ID { get; set; }

        [Column("Courier")]
        public int? Courier { get; set; }

        [Column("Ordered At")]
        public DateTime? Ordered_At { get; set; }

        [Column("Complited At")]
        public DateTime? Complited_At { get; set; }

        [Column("Status")]
        public int Status { get; set; }

        [Column("Order Grade")]
        public int? Order_Grade { get; set; }
    }
}

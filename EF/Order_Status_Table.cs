namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order Status Table")]
    public partial class Order_Status_Table
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column("Client Login", Order = 1)]
        [StringLength(30)]
        public string Client_Login { get; set; }

        [Key]
        [Column("Client Address ID", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_Address_ID { get; set; }

        [Column("Ordered At")]
        public DateTime? Ordered_At { get; set; }

        [Column("Complited At")]
        public DateTime? Complited_At { get; set; }

        [Key]
        [Column("Status ID", Order = 3)]
        public int Status_ID { get; set; }

        [Key]
        [Column("Status Value", Order = 4)]
        [StringLength(50)]
        public string Status_Value { get; set; }

        [Column("Order Grade")]
        public int? Order_Grade { get; set; }
    }
}

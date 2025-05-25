namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orders View")]
    public partial class Orders_View
    {
        [Key]
        [Column("Order ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        [Key]
        [Column("Client ID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_ID { get; set; }

        [Key]
        [Column("Client Address ID", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_Address_ID { get; set; }

        public int? Courier { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }

        [Column("Ordered At")]
        public DateTime? Ordered_At { get; set; }

        [Column("Complited At")]
        public DateTime? Complited_At { get; set; }

        [Key]
        [Column("Dish ID", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dish_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Count { get; set; }

        [Key]
        [Column("Producer ID", Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Producer_ID { get; set; }
    }
}

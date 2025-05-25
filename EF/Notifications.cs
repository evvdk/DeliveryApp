namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notifications
    {
        [Key]
        [Column("Client ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Client_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Value { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Send { get; set; }

        public short Read { get; set; }

        public virtual Client Client { get; set; }
    }
}

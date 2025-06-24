namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Информация о заказе")]
    public partial class Информация_о_заказе
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_заказа { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Логин { get; set; }

        public DateTime? Время_заказа { get; set; }

        public DateTime? Время_завершения_заказа { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Столик { get; set; }

        [Key]
        [Column("Значение столика", Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Значение_столика { get; set; }

        [Column("Расположение столика")]
        [StringLength(50)]
        public string Расположение_столика { get; set; }

        [Key]
        [Column("ID Статуса", Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ID_Статуса { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Статус { get; set; }
    }
}

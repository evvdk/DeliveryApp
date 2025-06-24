namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Блюда в заказе")]
    public partial class Блюда_в_заказе
    {
        public int? ID_заказа { get; set; }

        [StringLength(30)]
        public string Логин { get; set; }

        [Column("ID Статуса")]
        public short? ID_Статуса { get; set; }

        [StringLength(50)]
        public string Статус { get; set; }

        [StringLength(30)]
        public string Название { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Количество { get; set; }

        [Column("Название блюда")]
        [StringLength(30)]
        public string Название_блюда { get; set; }

        [Column(TypeName = "money")]
        public decimal? Цена { get; set; }

        public int? Масса { get; set; }

        public int? Калорийность { get; set; }

        [Column("Сумма стоимости блюда", TypeName = "money")]
        public decimal? Сумма_стоимости_блюда { get; set; }
    }
}

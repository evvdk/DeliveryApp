namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Состав_заказа
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_заказа { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Название_блюда { get; set; }

        public int Количество { get; set; }

        public virtual Заказ Заказ { get; set; }

        public virtual Меню Меню { get; set; }
    }
}

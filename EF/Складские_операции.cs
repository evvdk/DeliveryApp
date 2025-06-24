namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Складские_операции
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ингредиента { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_работника { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Дата_и_время { get; set; }

        public int Изменение { get; set; }

        public virtual Ингредиенты Ингредиенты { get; set; }

        public virtual Персонал Персонал { get; set; }
    }
}

namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказ()
        {
            Состав_заказа = new HashSet<Состав_заказа>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_заказа { get; set; }

        [Required]
        [StringLength(30)]
        public string Логин { get; set; }

        public int Официант { get; set; }

        public int Столик { get; set; }

        public short Статус { get; set; }

        public DateTime? Время_заказа { get; set; }

        public DateTime? Время_завершения_заказа { get; set; }

        public virtual Персонал Персонал { get; set; }

        public virtual Статус Статус1 { get; set; }

        public virtual Столик Столик1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Состав_заказа> Состав_заказа { get; set; }
    }
}

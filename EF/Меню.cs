namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Меню
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Меню()
        {
            Меню_Ингредиенты = new HashSet<Меню_Ингредиенты>();
            Состав_заказа = new HashSet<Состав_заказа>();
        }

        [Key]
        [StringLength(30)]
        public string Название { get; set; }

        [Column(TypeName = "money")]
        public decimal Цена { get; set; }

        [StringLength(100)]
        public string Описание { get; set; }

        public int? Калорийность { get; set; }

        public int? Масса { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Меню_Ингредиенты> Меню_Ингредиенты { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Состав_заказа> Состав_заказа { get; set; }
    }
}

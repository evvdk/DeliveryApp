namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ингредиенты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ингредиенты()
        {
            Меню_Ингредиенты = new HashSet<Меню_Ингредиенты>();
            Складские_операции = new HashSet<Складские_операции>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ингредиента { get; set; }

        [Required]
        [StringLength(30)]
        public string Название { get; set; }

        public int? Количество { get; set; }

        [StringLength(10)]
        public string Единица_измерения { get; set; }

        public int? Поставщик { get; set; }

        [Column(TypeName = "money")]
        public decimal? Цена_закупки { get; set; }

        public virtual Поставщик Поставщик1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Меню_Ингредиенты> Меню_Ингредиенты { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Складские_операции> Складские_операции { get; set; }
    }
}

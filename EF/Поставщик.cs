namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Поставщик
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщик()
        {
            Ингредиенты = new HashSet<Ингредиенты>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_поставщика { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Required]
        [StringLength(12)]
        public string Телефон { get; set; }

        [StringLength(30)]
        public string Фамилия_директора { get; set; }

        [StringLength(30)]
        public string Имя_директора { get; set; }

        [StringLength(30)]
        public string Отчество_директора { get; set; }

        [StringLength(50)]
        public string Эл_почта { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ингредиенты> Ингредиенты { get; set; }
    }
}

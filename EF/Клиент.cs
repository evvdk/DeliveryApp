namespace DeliveryApp.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Клиент
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_клиента { get; set; }

        [Required]
        [StringLength(30)]
        public string Логин { get; set; }

        [Required]
        [MaxLength(32)]
        public byte[] Пароль { get; set; }

        [Required]
        [StringLength(20)]
        public string Имя { get; set; }

        [Required]
        [StringLength(12)]
        public string Телефон { get; set; }

        [StringLength(50)]
        public string Эл_почта { get; set; }
    }
}

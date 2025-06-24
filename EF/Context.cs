using System.Data.Entity;

namespace DeliveryApp.EF
{
    public partial class Context : DbContext
    {
        public Context() : base() {}

        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Ингредиенты> Ингредиенты { get; set; }
        public virtual DbSet<Клиент> Клиент { get; set; }
        public virtual DbSet<Меню> Меню { get; set; }
        public virtual DbSet<Меню_Ингредиенты> Меню_Ингредиенты { get; set; }
        public virtual DbSet<Персонал> Персонал { get; set; }
        public virtual DbSet<Поставщик> Поставщик { get; set; }
        public virtual DbSet<Складские_операции> Складские_операции { get; set; }
        public virtual DbSet<Смена> Смена { get; set; }
        public virtual DbSet<Состав_заказа> Состав_заказа { get; set; }
        public virtual DbSet<Статус> Статус { get; set; }
        public virtual DbSet<Столик> Столик { get; set; }
        public virtual DbSet<Информация_о_заказе> Информация_о_заказе { get; set; }
        public virtual DbSet<Блюда_в_заказе> Блюда_в_заказе { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказ>()
                .HasMany(e => e.Состав_заказа)
                .WithRequired(e => e.Заказ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ингредиенты>()
                .Property(e => e.Цена_закупки)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ингредиенты>()
                .HasMany(e => e.Меню_Ингредиенты)
                .WithRequired(e => e.Ингредиенты)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ингредиенты>()
                .HasMany(e => e.Складские_операции)
                .WithRequired(e => e.Ингредиенты)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Клиент>()
                .Property(e => e.Пароль)
                .IsFixedLength();

            modelBuilder.Entity<Клиент>()
                .Property(e => e.Телефон)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Клиент>()
                .Property(e => e.Эл_почта)
                .IsUnicode(false);

            modelBuilder.Entity<Меню>()
                .Property(e => e.Цена)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Меню>()
                .HasMany(e => e.Меню_Ингредиенты)
                .WithRequired(e => e.Меню)
                .HasForeignKey(e => e.Название_блюда)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Меню>()
                .HasMany(e => e.Состав_заказа)
                .WithRequired(e => e.Меню)
                .HasForeignKey(e => e.Название_блюда)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Персонал>()
                .Property(e => e.Телефон)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Персонал>()
                .Property(e => e.Паспорт)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Персонал>()
                .Property(e => e.Трудовая_книжка)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Персонал>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Персонал)
                .HasForeignKey(e => e.Официант)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Персонал>()
                .HasMany(e => e.Складские_операции)
                .WithRequired(e => e.Персонал)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Персонал>()
                .HasMany(e => e.Смена)
                .WithMany(e => e.Персонал)
                .Map(m => m.ToTable("График_работы").MapLeftKey("ID_работника").MapRightKey("Номер_смены"));

            modelBuilder.Entity<Поставщик>()
                .Property(e => e.Телефон)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Поставщик>()
                .Property(e => e.Эл_почта)
                .IsUnicode(false);

            modelBuilder.Entity<Поставщик>()
                .HasMany(e => e.Ингредиенты)
                .WithOptional(e => e.Поставщик1)
                .HasForeignKey(e => e.Поставщик);

            modelBuilder.Entity<Смена>()
                .Property(e => e.Оплата_в_час)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Статус>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Статус1)
                .HasForeignKey(e => e.Статус)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Столик>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Столик1)
                .HasForeignKey(e => e.Столик)
                .WillCascadeOnDelete(false);
        }
    }
}

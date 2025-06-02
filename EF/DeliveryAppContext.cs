namespace DeliveryApp.EF
{
    using System.Data.Entity;

    public partial class DeliveryAppContext : DbContext
    {
        public DeliveryAppContext() : base()
        {
            Database.SetInitializer<DeliveryAppContext>(null);
        }

        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Client_Address> Client_Address { get; set; }
        public virtual DbSet<Courier> Courier { get; set; }
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Dishes_Order> Dishes_Order { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Producer> Producer { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<Address_By_Login> Address_By_Login { get; set; }
        public virtual DbSet<All_Dishes> All_Dishes { get; set; }
        public virtual DbSet<Dish_All_Info> Dish_All_Info { get; set; }
        public virtual DbSet<Order_On_Producer> Order_On_Producer { get; set; }
        public virtual DbSet<Order_Set> Order_Set { get; set; }
        public virtual DbSet<Order_Status_Table> Order_Status_Table { get; set; }
    }
}

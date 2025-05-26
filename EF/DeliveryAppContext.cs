namespace DeliveryApp.EF
{
    using System.Data.Entity;

    public partial class DeliveryAppContext : DbContext
    {
        public DeliveryAppContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<DeliveryAppContext>(null);
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Client_Address> Client_Address { get; set; }
        public virtual DbSet<Courier> Courier { get; set; }
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Dishes_Order> Dishes_Order { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Producer> Producer { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Order_Status_Table> Order_Status_Table { get; set; }
        public virtual DbSet<Orders_View> Orders_View { get; set; }
        public virtual DbSet<Address_By_Login> Address_By_Login { get; set; }
        public virtual DbSet<Order_Summary> Order_Summary { get; set; }
    }
}

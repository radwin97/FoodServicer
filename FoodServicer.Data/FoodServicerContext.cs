using FoodServicer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace FoodServicer.Data
{
    public class FoodServicerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Conversion> Conversions { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<EmailAddressType> EmailAddressTypes { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Database=foodservicer;User=root;Password=Abcd1234!;",
                    mysqlOptions =>
                    {
                        mysqlOptions.ServerVersion(new System.Version(5, 5, 62), ServerType.MySql);
                    });
        }
    }
}

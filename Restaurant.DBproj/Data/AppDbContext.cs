using Microsoft.EntityFrameworkCore;
using RestaurantManagement.DBproj.Models.Workers;
using RestaurantManagement.DBproj.Models;

namespace RestaurantManagement.DBproj.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DiningTable> DiningTables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}

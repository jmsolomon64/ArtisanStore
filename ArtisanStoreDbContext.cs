using ArtisanStore.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtisanStore
{
    public class ArtisanStoreDbContext : DbContext
    {
        //Constructor for this class
        public ArtisanStoreDbContext(DbContextOptions<ArtisanStoreDbContext> options) : base(options) { }

        //Properties for context are data sets based off Data classes
        public DbSet<Category> Categories {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<Product> Products {get; set;}
        public DbSet<User> Users {get; set;}
    }
}
using Microsoft.EntityFrameworkCore;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Restaurant> restaurants { get; set; }
        public DbSet<Review> reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database = ReviewSite; Trusted_connection=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            

            builder.Entity<Restaurant>().HasData(new Restaurant() { Id = 1, Name = "McDonalds",   Address = "Cleveland"});
            builder.Entity<Restaurant>().HasData(new Restaurant() { Id = 2, Name = "Wendys",   Address = "Cleveland" });
            builder.Entity<Restaurant>().HasData(new Restaurant() { Id = 3, Name = "Chick-Fil-A",  Address = "Cleveland" });

            builder.Entity<Review>().HasData(new Review() { Id = 1, Name = "Sue", Content = "Absolutely the worst restaurant!Always short staffed...", RestaurantId = 1});
            builder.Entity<Review>().HasData(new Review() { Id = 2, Name = "Leah", Content =  "Overrated!",  RestaurantId = 2 });
            builder.Entity<Review>().HasData(new Review() { Id = 3, Name = "Poppy", Content = "Very Meeeeeeh!", RestaurantId = 3 });


        }
    }

}

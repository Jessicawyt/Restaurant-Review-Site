using Microsoft.EntityFrameworkCore;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Restaurant> restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database = Courses2022; Trusted_connection=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Restaurant>().HasData(new Restaurant() { Id = 1, Name = "McDonalds", Review = "Love it!", Address = "Cleveland"});
            builder.Entity<Restaurant>().HasData(new Restaurant() { Id = 2, Name = "Wendys", Review = "Better than Mcd!", Address = "Cleveland" });
            builder.Entity<Restaurant>().HasData(new Restaurant() { Id = 3, Name = "Chick-Fil-A", Review = "Overrated!", Address = "Cleveland" });
       

        }
    }

}

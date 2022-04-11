using Microsoft.EntityFrameworkCore;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database = ReviewSite; Trusted_connection=True");
            builder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<Restaurant>().HasData(new Restaurant() { 
                Id = 1, 
                Name = "McDonalds",   
                Address = "Cleveland", 
                Information = "McDonald's is the most popular and common fast food chain in The USA and Canada. McDonald's is the world's largest restaurant chain by revenue, serving over 69 million customers daily in over 100 countries across 37,855 outlets as of 2018", 
                Image = "https://th.bing.com/th/id/R.a7030fb5624db3715b9a0b0698b1352f?rik=qMWOVvISFUC9Ig&riu=http%3a%2f%2fpngimg.com%2fuploads%2fmcdonalds%2fmcdonalds_PNG19.png&ehk=DcGet8JyK0nOmVYPW80XxvGb5RhYzJs4JLr%2fCOBW8Wk%3d&risl=&pid=ImgRaw&r=0"
            });  
            
            builder.Entity<Restaurant>().HasData(new Restaurant() { Id = 2, Name = "Wendys",   Address = "Cleveland", Information = "Wendy's is an American international fast food restaurant chain founded by Dave Thomas on November 15, 1969, in Columbus, Ohio.", Image= "https://freepikpsd.com/file/2019/11/wendys-logo-transparent-png-2-Images.png" });  
            builder.Entity<Restaurant>().HasData(new Restaurant() { Id = 3, Name = "Chick-Fil-A",  Address = "Cleveland", Information = "Chick-fil-A a play on the American English pronunciation of filet. Is one of the largest American fast food restaurant chains and the largest whose specialty is chicken sandwiches. Its headquarters is in College Park, Georgia.",Image= "https://logos-world.net/wp-content/uploads/2021/08/Chick-fil-A-Emblem.png" }); 

            builder.Entity<Review>().HasData(new Review() { Id = 1, Name = "Sue", Content = "Absolutely the worst restaurant!Always short staffed...", RestaurantId = 1});
            builder.Entity<Review>().HasData(new Review() { Id = 2, Name = "Leah", Content =  "Overrated!",  RestaurantId = 2 });
            builder.Entity<Review>().HasData(new Review() { Id = 3, Name = "Poppy", Content = "Very Meeeeeeh!", RestaurantId = 3 });


        }
    }

}

using System.Collections.Generic;

namespace template_csharp_reviews_site.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public Restaurant(string name, List<Review> reviews, string address)
        {
            this.Reviews = reviews;
            this.Name = name;
            this.Address = address;
        }

    }
}

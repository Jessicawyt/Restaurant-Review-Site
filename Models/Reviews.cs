namespace template_csharp_reviews_site.Models
{
    public class Review
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }

      //  public string RestaurantName { get; set; }


    }
}

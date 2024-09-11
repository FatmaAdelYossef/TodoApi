namespace TodoApi.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Image { get; set; }
        public string? Secret { get; set; }
    }
}

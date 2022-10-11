namespace SimpleApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Category CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
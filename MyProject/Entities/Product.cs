namespace MyProject.Entities
{
    public class Product
    {
        static int id;
        public int ProductId { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Marketer { get; set; }

        public Product(string name, string description, string picture, string marketer)
        {
            ProductId = id++;
            Name = name;
            Description = description;
            Picture = picture;
            Marketer = marketer;
        }
    }
}

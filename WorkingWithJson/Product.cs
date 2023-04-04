namespace WorkingWithJson
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Colors { get; set; }

        public Product(int id, string name, string description, string[] colors)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Colors = colors;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Colors: {string.Join(",", Colors)}";
        }
    }
}

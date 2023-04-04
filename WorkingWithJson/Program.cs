using Newtonsoft.Json;

namespace WorkingWithJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JSONCONVERT - wrapper over JSONSERIALIZER
            //FOR SIMPLE USE CASES

            //JSONSERIALIZER - converts .NET object to JSON and vice versa
            // USE THIS FOR MORE CONTROL

            //jsonconvert example: serialze - obj to string
            Product product1 = new Product(1, "iphone", "v.1", new string[] { "Red", "Green", "yellow" });
            string outJsonStr = JsonConvert.SerializeObject(product1);
            Console.WriteLine("Object to string: " + outJsonStr);

            //jsonconvert example: deSerialze string to object
            string inJsonStr = "{\"Id\":1,\"Name\":\"iphone\",\"Description\":\"v.2\",\"Colors\":[\"Purple\",\"Orange\",\"Brown\"]}";
            Product product2 = JsonConvert.DeserializeObject<Product>(inJsonStr);
            Console.WriteLine("String to Object: " + product2);

        }
    }


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
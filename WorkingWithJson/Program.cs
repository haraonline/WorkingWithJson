﻿using Newtonsoft.Json;

namespace WorkingWithJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JsonConvert       : Wrapper over JsonSerializer. Use this for simple scenarios
            //JsonSerializer    : Use this for more control

            //JsonConvert Example: Serialze (.NET Object to string)
            Product product1 = new Product(1, "iphone", "v.1", new string[] { "Red", "Green", "yellow" });
            string outJsonStr = JsonConvert.SerializeObject(product1);
            Console.WriteLine("Object to string: " + outJsonStr);

            //JsonConvert Example: Deserialze (String to .NET Object)
            string inJsonStr = "{\"Id\":1,\"Name\":\"iphone\",\"Description\":\"v.2\",\"Colors\":[\"Purple\",\"Orange\",\"Brown\"]}";
            Product product2 = JsonConvert.DeserializeObject<Product>(inJsonStr);
            Console.WriteLine("String to Object: " + product2);

        }
    }   
}
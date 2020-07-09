using Newtonsoft.Json;
using System;

namespace _42_ConsumeData
{
    public static class ConsumeJson
    {
        public static void GetExample()
        {
            var jsonProduct = "{ \"description\": \"Product 5\", \"quantity\": 500, \"price\": 150.0 }";

            var product = JsonConvert.DeserializeObject<Product>(jsonProduct);

            Console.WriteLine($"Description: {product.Description}, Quantity: {product.Quantity}, Price: {product.Price}");

            jsonProduct = JsonConvert.SerializeObject(product);

            Console.WriteLine(jsonProduct);
        }
    }

    public class Product
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

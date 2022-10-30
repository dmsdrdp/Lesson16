using System;
using System.IO;
using System.Text.Json;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach (Product e in products)
            {
                if (e.Price>maxProduct.Price)
                {
                    maxProduct = e;
                }
            }
            Console.WriteLine($"{maxProduct.Code} {maxProduct.Name} {maxProduct.Price}");
            Console.Read();
        }
    }
}

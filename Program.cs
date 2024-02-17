// See https://aka.ms/new-console-template for more information
using ConAppProducts;

class Program
{
    static void Main(string[] args)
    {
        // Creating a product instance
        Products product1 = new Products("Laptop", 999.99m, "BrandX", new DateTime(2023, 5, 15), new DateTime(2026, 5, 15));

        // Displaying product details
        Console.WriteLine(product1);
    }
}

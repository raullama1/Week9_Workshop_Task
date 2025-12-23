using Week9.Models;

namespace Week9.Data;

// Stores products in memory
public static class ProductStore
{
    // Static list
    public static List<Product> Products { get; } = new();

    // Auto-increment product id
    private static int _nextId = 1;

    // Add product to the list
    public static void Add(Product product)
    {
        product.Id = _nextId++;
        Products.Add(product);
    }
}
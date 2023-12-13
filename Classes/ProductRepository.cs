using ProductManagement.Classes.Products;
using ProductManagement.Interfaces;

namespace ProductManagement.Classes;

public class ProductRepository : IProductRepository
{
    private List<Product> _products = new List<Product>();

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Remove(Product product)
    {
        _products.Remove(product);
    }

    public void AddRange(IEnumerable<Product> products)
    {
        _products.AddRange(products);
    }

    public IEnumerable<Product> GetProducts()
    {
        return _products;
    }




}

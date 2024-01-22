using ProductManagement.Classes.Products;

namespace ProductManagement.Interfaces;

public interface IProductRepository
{
    void Add(Product product);
    void Remove(Product product);
    void AddRange(IEnumerable<Product> products);
    IEnumerable<Product> GetProducts();
}
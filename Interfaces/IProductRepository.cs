namespace ProductManagement;

public interface IProductRepository
{
    void Add(Product product);
    void AddRange(IEnumerable<Product> products);
    IEnumerable<Product> GetProducts();
}
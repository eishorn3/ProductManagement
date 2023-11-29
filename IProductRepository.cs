namespace ProductManagement;

public interface IProductRepository
{
    void Add();
    IEnumerable<Product> GetProducts();
}
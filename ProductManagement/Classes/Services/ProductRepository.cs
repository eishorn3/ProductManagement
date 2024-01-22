using ProductManagement.Classes.Products;
using ProductManagement.Interfaces;

namespace ProductManagement.Classes;

public class ProductRepository : IProductRepository
{
    private List<Product> _products = new List<Product>();
    private readonly IJsonDataService _jsonDataService;

    public ProductRepository(IJsonDataService jsonDataService)
    {
        _jsonDataService = jsonDataService;
        _products = (List<Product>)_jsonDataService.JsonLoad();
    }
    public void Add(Product product)
    {
        _products.Add(product);
        _jsonDataService.JsonSave(_products);
    }

    public void Remove(Product product)
    {
        _products.Remove(product);
        _jsonDataService.JsonSave(_products);

    }

    public void AddRange(IEnumerable<Product> products)
    {
        _products.AddRange(products);
        _jsonDataService.JsonSave(_products);

    }

    public IEnumerable<Product> GetProducts()
    {
        return _products;
    }





}

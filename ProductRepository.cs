namespace ProductManagement;

public class ProductRepository : IProductRepository
{
    private IList<Product> _products = new List<Product>();

    public void Add()
    {
        var product = new Product();

        Console.WriteLine("Please enter the category: ");
        product.ProductCategory = Console.ReadLine();

        Console.WriteLine("Please enter the brand: ");
        product.ProductBrand = Console.ReadLine();

        Console.WriteLine("Please enter the name: ");
        product.ProductName = Console.ReadLine();

        Console.WriteLine("Please enter the definition: ");
        product.ProductDefinition = Console.ReadLine();

        Console.WriteLine("Please enter the price: ");
        product.ProductPrice = Convert.ToDecimal(Console.ReadLine());

        _products.Add(product);
    }

    public IEnumerable<Product> GetProducts()
    {
        return _products;
    }
}

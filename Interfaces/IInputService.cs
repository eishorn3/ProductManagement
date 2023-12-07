using ProductManagement.Classes.Products;

namespace ProductManagement.Interfaces;

public interface IInputService
{
    public Product CreateProductInput(Product product);
    //    Product DeleteInput(IList<Product> products);
    public void DisplayUserOptions();
    public Product EditProduct();
    //    IProduct CreateProduct();
    //    ____
    //    //Product AddProduct();
    //    //void EditProduct();
    //    //public IList<Product> DeleteProduct();
}
using ProductManagement.Classes.Products;

namespace ProductManagement.Interfaces;

public interface IInputService
{
    public void ShowProduct();
    //    Product DeleteInput(IList<Product> products);
    public void DisplayUserOptions();
    public Product EditProduct();

    //    IProduct CreateProduct();
    //    ____
    //    //Product AddProduct();
    //    //void EditProduct();
    //    //public IList<Product> DeleteProduct();

}
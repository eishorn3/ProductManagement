using ProductManagement.Classes.Products;

namespace ProductManagement.Interfaces;

public interface IInputService
{
    public void DisplayUserOptions();
    public void CreateProduct();
    public Product EditProduct();
    public void ShowProduct();
    public void DeleteProduct();


}
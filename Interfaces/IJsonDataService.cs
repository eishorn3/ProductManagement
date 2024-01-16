using ProductManagement.Classes.Products;

public interface IJsonDataService
{
    void JsonSave(IList<Product> products);
    IList<Product> JsonLoad();
}

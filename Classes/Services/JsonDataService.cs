using ProductManagement.Classes.Products;

public class JsonDataService : IJsonDataService
{
    public IList<Product> JsonLoad()
    {
        if (File.Exists("newy.json"))
        {
            var products2 = System.Text.Json.JsonSerializer.Deserialize<IList<Product>>(File.ReadAllText("newy.json"));
            return products2;
        }

        return new List<Product>();
    }
    public void JsonSave(IList<Product> products)
    {
        File.WriteAllText("newy.json", System.Text.Json.JsonSerializer.Serialize(products));
    }
}



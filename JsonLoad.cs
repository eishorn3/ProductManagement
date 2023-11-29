public class JsonLoad
{
    public IList<Product> LoadProducts()
    {
        if (File.Exists("newy.json"))
        {
            var products2 = System.Text.Json.JsonSerializer.Deserialize<IList<Product>>(File.ReadAllText("newy.json"));
            foreach (var item in products2)
            {
                item.WriteToConsole();
            }
            return products2;
        }

        return new List<Product>();
    }
}
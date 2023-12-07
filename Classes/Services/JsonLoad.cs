//public class JsonLoad
//{
//    public IList<Product> LoadProducts()
//    {
//        if (File.Exists("newy.json"))
//        {
//            var products2 = System.Text.Json.JsonSerializer.Deserialize<IList<Product>>(File.ReadAllText("newy.json"));
//            // interface draus machen f jsonload&save, 1 klasse
//            return products2;
//        }

//        return new List<Product>();
//    }
//}
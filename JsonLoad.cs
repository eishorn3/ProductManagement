using System;
using System.Text.Json;
public class JsonLoad
{
	public JsonLoad()
	{
        if (File.Exists("newy.json")){ 
        var products2 = System.Text.Json.JsonSerializer.Deserialize<IList<Product>>(File.ReadAllText("newy.json"));
        foreach (var item in products2)
        {
            item.WriteToConsole();
        }
        }
        else { Console.WriteLine("NOOOOOOO"); }

    }
}

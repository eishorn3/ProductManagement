using System;

public class JsonLoad
{
	public JsonLoad()
	{
        if (File.Exists("newy.json")){ 
        var products2 = System.Text.Json.JsonSerializer.Deserialize<List<IProduct>>(File.ReadAllText("newy.json"));
        foreach (var item in products2)
        {
            item.WriteToConsole();
        }
        }

    }
}

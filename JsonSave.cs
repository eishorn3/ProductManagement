using System;
using System.IO.Enumeration;

public class JsonSave
{
    public JsonSave(IList<Product> products)
	{ 
        {
            File.WriteAllText("newy.json", System.Text.Json.JsonSerializer.Serialize(products));
        }
    }
}

using System;
using System.IO.Enumeration;

public class JsonSave: List<IProduct>
{
    public JsonSave(List<IProduct> products)
	{ 
        {
            File.WriteAllText("newy.json", System.Text.Json.JsonSerializer.Serialize(products));
        }
    }
}

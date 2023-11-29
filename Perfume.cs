using System.Text.Json.Serialization;

[Serializable]
public class Perfume : Product
{
    [JsonInclude]
    [JsonPropertyName("productScent")]
    public string? ProductScent { get; set; }


    public override string ToString()
    {
        return base.ToString() + $"\tProductScent: {ProductScent}\n";
    }

    //public override void questionsAdd()
    //{
    //    base.questionsAdd();
    //    Console.WriteLine("Please enter the scent: ");
    //    string productScent = Console.ReadLine();
    //    ProductScent = productScent;

    //}
}

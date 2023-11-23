using System.Text.Json.Serialization;

[Serializable]
public class Perfume : IProduct
{
    [JsonInclude]
    [JsonPropertyName("productScent")]
    public string ProductScent { get; set; }
    public string ProductCategory { get; set; }
    public string ProductBrand { get; set; }
    public string ProductName { get; set; }
    public string ProductDefinition { get; set; }
    public decimal ProductPrice { get; set; }

    public Perfume()
    {

    }

    public Perfume(string productCategory, string productBrand, string productName, string productDefinition, decimal productPrice, string productScent) 
    {
        ProductCategory = productCategory;
        ProductBrand = productBrand;
        ProductName = productName;
        ProductDefinition = productDefinition;
        ProductPrice = productPrice;
        ProductScent = productScent;
    }

    public void WriteToConsole()
    {
        Console.WriteLine($"ProductScent: {ProductScent}\tProductCategory: {ProductCategory}\t ProductBrand: {ProductBrand}\t ProductName: {ProductName}\t ProductDefinition: {ProductDefinition}\t ProductPrice: {ProductPrice}\t");
    }

    public  void QuestionsAdd()
    {
        Console.WriteLine("Please enter the category: ");
        ProductCategory = Console.ReadLine();

        Console.WriteLine("Please enter the brand: ");
        ProductBrand = Console.ReadLine();

        Console.WriteLine("Please enter the name: ");
        ProductName = Console.ReadLine();

        Console.WriteLine("Please enter the definition: ");
        ProductDefinition = Console.ReadLine();

        Console.WriteLine("Please enter the price: ");
        ProductPrice = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please enter the scent: ");
       ProductScent = Console.ReadLine();

    }


}

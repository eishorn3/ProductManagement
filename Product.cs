using System.Text.Json.Serialization;

[JsonDerivedType(typeof(Lipstick), typeDiscriminator: "L")]
[JsonDerivedType(typeof(Perfume), typeDiscriminator: "P")]
public class Product
{
    public string? ProductCategory { get; set; }
    public string? ProductBrand { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDefinition { get; set; }
    public decimal? ProductPrice { get; set; }

    public override string ToString()
    {
        return $"ProductCategory: {ProductCategory}\t | \tProductName: {ProductName}\t | \tProductBrand: {ProductBrand}\t | \tProductDefinition: {ProductDefinition}\t | \tProductPrice: {ProductPrice}\t";
    }

    //public virtual void questionsAdd()
    //{
    //    Console.WriteLine("Please enter the category: ");
    //    ProductCategory = Console.ReadLine();

    //    Console.WriteLine("Please enter the brand: ");
    //    ProductBrand = Console.ReadLine();

    //    Console.WriteLine("Please enter the name: ");
    //    ProductName = Console.ReadLine();

    //    Console.WriteLine("Please enter the definition: ");
    //    ProductDefinition = Console.ReadLine();

    //    Console.WriteLine("Please enter the price: ");
    //    ProductPrice = Convert.ToDecimal(Console.ReadLine());
    //}


}
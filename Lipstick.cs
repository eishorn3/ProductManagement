[Serializable]
public class Lipstick : IProduct
{
    public string ProductColour { get; set; }
    public string ProductCategory { get; set; }
    public string ProductBrand { get; set; }
    public string ProductName { get; set; }
    public string ProductDefinition { get; set; }
    public decimal ProductPrice { get; set ; }

    public Lipstick()
    {

    }
    public Lipstick(string productCategory, string productBrand, string productName, string productDefinition, decimal productPrice, string productColour)
    {
        ProductCategory = productCategory;
        ProductColour = productColour;
        ProductBrand = productBrand;
        ProductName = productName;
        ProductDefinition = productDefinition;
        ProductPrice = productPrice;
    }

   public void WriteToConsole()
    {
        Console.WriteLine($"ProductColour: {ProductColour}\t ProductCategory: {ProductColour}\t ProductBrand: {ProductBrand}\t ProductName: {ProductName}\t ProductDefinition: {ProductDefinition}\t ProductPrice: {ProductPrice}\t");
    }



   public void QuestionsAdd()
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
        Console.WriteLine("Please enter the new colour: ");
        ProductColour = Console.ReadLine();

    }
}
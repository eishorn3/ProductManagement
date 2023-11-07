using Newtonsoft.Json;
using System;

[Serializable]
public class Product
{
    public string ProductCategory { get; set; }
    public string ProductBrand { get; set; }
    public string ProductName { get; set; }
    public string ProductDefinition { get; set; }
    public decimal ProductPrice { get; set; }

    public Product()
    {

    }

    public Product(string productCategory, string productBrand, string productName, string productDefinition, decimal productPrice)
    {
        ProductCategory = productCategory;
        ProductBrand = productBrand;
        ProductName = productName;
        ProductDefinition = productDefinition;
        ProductPrice = productPrice;
    }
    public void WriteToConsole()
    {
        Console.WriteLine($"ProductCategory: {ProductCategory}\t | \tProductName: {ProductName}\t | \tProductBrand: {ProductBrand}\t | \tProductDefinition: {ProductDefinition}\t | \tProductPrice: {ProductPrice}\t");
    }

    public void questionsAdd()
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
    }


}






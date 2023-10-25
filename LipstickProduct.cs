using System;

public class Lipstick:Product
{
    public string ProductColour { get; set; }

    public Lipstick(string productCategory, string productBrand, string productName, string productDefinition, decimal productPrice, string productColour):base (productCategory, productBrand, productName, productDefinition, productPrice)
    {
        ProductColour = productColour;
    }

    public void WriteToConsole()
    {
        Console.WriteLine($"ProductName: {ProductName}\t | \tProductBrand: {ProductBrand}\t | \tProductDefinition: {ProductDefinition}\t | \tProductPrice: {ProductPrice}\t | \tProductColour: {ProductColour}\t");
    }

    public void questionsAddLipstick()
    {
        questionsAdd();
        Console.WriteLine("Please enter the new colour: ");
        string productColour = Console.ReadLine();

    }
}
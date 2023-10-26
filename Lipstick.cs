using System;

public class Lipstick : Product
{
    public string ProductColour { get; set; }

    public Lipstick()
    {
        
    }

    public Lipstick(string productCategory, string productBrand, string productName, string productDefinition, decimal productPrice, string productColour) : base(productCategory, productBrand, productName, productDefinition, productPrice)
    {
        ProductColour = productColour;
    }

    public void LipstickWriteToConsole()
    {
        WriteToConsole();
        Console.WriteLine($"ProductColour: {ProductColour}\t");
    }

    public void questionsAddLipstick()
    {
        questionsAdd();
        Console.WriteLine("Please enter the new colour: ");
        string productColour = Console.ReadLine();
        ProductColour = productColour;
    }
}
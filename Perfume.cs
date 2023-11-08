using System;
[Serializable]

public class Perfume : Product
{
    public string ProductScent { get; set; }

    public Perfume()
    {
        
    }

    public Perfume(string productCategory, string productBrand, string productName, string productDefinition, decimal productPrice, string productScent)
        : base(productCategory, productBrand, productName, productDefinition, productPrice)
    {
        ProductScent = productScent;
    }

    public override void WriteToConsole()
    {
        base.WriteToConsole();
        Console.WriteLine($"ProductScent: {ProductScent}\t");
    }

    public override void questionsAdd()
    {
        base.questionsAdd();
        Console.WriteLine("Please enter the scent: ");
        string productScent = Console.ReadLine();
        ProductScent = productScent;

    }
}

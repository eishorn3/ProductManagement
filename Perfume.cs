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

    public void WriteToConsole()
    {
        Console.WriteLine($"ProductName: {ProductName}\t | \tProductBrand: {ProductBrand}\t | \tProductDefinition: {ProductDefinition}\t | \tProductPrice: {ProductPrice}\t | \tProductScent: {ProductScent}\t");
    }
    public void questionsAddPerfume()
    {
        base.questionsAdd();
        Console.WriteLine("Please enter the scent: ");
        string productScent = Console.ReadLine();
        ProductScent = productScent; 

    }
}

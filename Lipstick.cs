[Serializable]
public class Lipstick : Product, IAddTo
{
    public string ProductColour { get; set; }

    public Lipstick()
    {

    }
    public Lipstick(string productCategory, string productBrand, string productName, string productDefinition, decimal productPrice, string productColour) : base(productCategory, productBrand, productName, productDefinition, productPrice)
    {
        ProductColour = productColour;
    }

    public override void WriteToConsole()
    {
        base.WriteToConsole();
        Console.WriteLine($"ProductColour: {ProductColour}\t");
    }


    public override void questionsAdd()
    {
        base.questionsAdd();
        Console.WriteLine("Please enter the new colour: ");
        string productColour = Console.ReadLine();
        ProductColour = productColour;

    }

    public void AddTo()
    {
        this.questionsAdd();
        this.WriteToConsole();
    }
}
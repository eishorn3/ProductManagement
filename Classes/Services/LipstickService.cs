using ProductManagement.Classes.Products;

namespace ProductManagement;

public class LipstickService : ILipstickService
{

    public LipstickService()
    {
    }

    public Lipstick CreateLipsticktInput()
    {
        var lipstick = new Lipstick();

        Console.WriteLine("Please enter the brand: ");
        lipstick.ProductBrand = Console.ReadLine();

        Console.WriteLine("Please enter the name: ");
        lipstick.ProductName = Console.ReadLine();

        Console.WriteLine("Please enter the definition: ");
        lipstick.ProductDefinition = Console.ReadLine();

        Console.WriteLine("Please enter the price: ");
        lipstick.ProductPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the colour: ");
        lipstick.ProductColour = Console.ReadLine();

        return lipstick;
    }

    public void EditLipsticktInput(Lipstick lipstick)
    {
        Console.WriteLine("Please enter the brand: ");
        lipstick.ProductBrand = Console.ReadLine();

        Console.WriteLine("Please enter the name: ");
        lipstick.ProductName = Console.ReadLine();

        Console.WriteLine("Please enter the definition: ");
        lipstick.ProductDefinition = Console.ReadLine();

        Console.WriteLine("Please enter the price: ");
        lipstick.ProductPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the colour: ");
        lipstick.ProductColour = Console.ReadLine();
    }
}
using ProductManagement.Classes.Products;
using ProductManagement.Interfaces;

namespace ProductManagement;

public class LipstickService : Lipstick, ILipstickService
{
    private readonly IInputService inputService;

    public LipstickService(IInputService inputService)
    {
        this.inputService = inputService;
    }
    public Lipstick CreateLipsticktInput()
    {
        var lipstick = new Lipstick();
        lipstick = (Lipstick)this.inputService.CreateProductInput(lipstick);
        Console.WriteLine("Please enter the colour: ");
        lipstick.ProductColour = Console.ReadLine();

        return lipstick;
    }
}
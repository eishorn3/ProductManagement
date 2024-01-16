using ProductManagement.Classes.Products;
using ProductManagement.Interfaces;

namespace ProductManagement.Classes.Services;

public class InputService : IInputService
{
    private readonly ILipstickService _lipstickService;
    private readonly IProductRepository _productRepository;
    private readonly IPerfumeService _perfumeService;

    public InputService(IProductRepository productRepository, ILipstickService lipstickService, IPerfumeService perfumeService)
    {
        _productRepository = productRepository;
        _lipstickService = lipstickService;
        _perfumeService = perfumeService;
    }
    public void DisplayUserOptions()
    {
        Console.WriteLine("Hey! Welcome to our Douglas Prodcut Management Site.");
        Console.WriteLine("1: Add a product");
        Console.WriteLine("2: Edit a product");
        Console.WriteLine("3: Show a product");
        Console.WriteLine("4: Delete a product");
        Console.WriteLine("5: Close the Product Manager");
        Console.WriteLine("Choose an option: ");
        UserChoice userChoice = new UserChoice();

    }
    public void CreateProduct()
    {
        Console.WriteLine("Please enter a category: ");
        var input = Console.ReadLine();
        if (input?.ToLowerInvariant() == "lipstick")
        {
            var lipstick = _lipstickService.CreateLipsticktInput();
            _productRepository.Add(lipstick);
        }
        else if (input?.ToLowerInvariant() == "perfume")
        {
            var perfume = _perfumeService.CreatePerfumeInput();
            _productRepository.Add(perfume);
        }

    }
    public void ShowProduct()
    {
        foreach (var item in _productRepository.GetProducts())
        {
            Console.WriteLine(item);
        }
    }
    public Product EditProduct()
    {
        ShowProduct();
        Console.WriteLine("\nPlease choose item to edit (input position number): ");
        var position = Convert.ToInt32(Console.ReadLine());

        var products = _productRepository.GetProducts().ToList();

        if (position == 0 || position > products.Count)
        {
            Console.WriteLine("This position is not allowed");
        }
        var elementToEdit = products[position - 1];

        if (elementToEdit is Lipstick lipstick)
        {
            _lipstickService.EditLipsticktInput(lipstick);
        }
        else if (elementToEdit is Perfume perfume)
        {
            _perfumeService.EditPerfumeInput(perfume);
        }
        return elementToEdit;

    }
    public void DeleteProduct()
    {
        ShowProduct();

        Console.WriteLine("Please choose item to delete (input position number): ");
        var position = Convert.ToInt32(Console.ReadLine());

        var products = _productRepository.GetProducts().ToList();


        if (position == 0 || position > products.Count)
        {
            Console.WriteLine("This position is not allowed");
        }

        var elementToDelete = products[position - 1];

        _productRepository.Remove(elementToDelete);

        Console.WriteLine("The product has been successfully deleted\n");

    }


}

using ProductManagement.Classes;
using ProductManagement.Classes.Services;
using ProductManagement.Interfaces;

namespace ProductManagement;

public class Program
{
    private static IJsonDataService _jsonDataService = new JsonDataService();
    public static IProductRepository ProductRepository = new ProductRepository(_jsonDataService);
    private static readonly ILipstickService LipstickService = new LipstickService();
    private static readonly IPerfumeService PerfumeService = new PerfumeService();

    private static readonly IInputService InputService = new InputService(ProductRepository, LipstickService, PerfumeService);

    public static IUserChoice UserChoice = new UserChoice();

    public static void Main(string[] args)
    {


        while (true)
        {

            InputService.DisplayUserOptions();
            var displayInput = UserChoice.choiceTwo();


            switch (displayInput)
            {
                case 1:
                    InputService.CreateProduct();
                    break;
                case 2:
                    InputService.ShowProduct();
                    break;
                case 3:
                    InputService.EditProduct();
                    break;
                case 4:
                    InputService.DeleteProduct();
                    break;
                default:
                    break;



            }

        }
    }
}

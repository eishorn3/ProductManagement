using ProductManagement.Classes;
using ProductManagement.Classes.Services;
using ProductManagement.Interfaces;

namespace ProductManagement;

public class Program
{
    private static IInputService _inputService = new InputService();
    public static IUserChoice _userChoice = new UserChoice();
    public static IProductRepository _productRepository = new ProductRepository();
    public static ILipstickService _lipstickService = new LipstickService(_inputService);
    //private static IInputService _inputService = new InputService();
    //private static IJsonSaveLoadService _saveLoad = new JsonSaveLoadService();
    public static void Main(string[] args)
    {
        //UserChoice userChoice = new UserChoice();
        //InputService inputService = new InputService();
        //string lipstickInput = userChoice.choiceOne();
        //decimal perfumeInput = userChoice.choiceTwo();

        while (true)
        {
            //inputService.DisplayUserOptions();
            //decimal displayInput = userChoice.choiceTwo();
            _inputService.DisplayUserOptions();
            var displayInput = _userChoice.choiceTwo();

            //decimal displayInput = userChoice.choiceTwo();

            switch (displayInput)
            {
                case 1:
                    CreateProduct();
                    break;
                case 2:
                    EditProduct();
                    break;
                case 3:
                    ShowProduct();
                    break;
                default:
                    break;

                    void CreateProduct()
                    {
                        Console.WriteLine("Please enter the category: ");
                        var input = Console.ReadLine();
                        if (input?.ToLowerInvariant() == "lipstick")
                        {
                            var lipstick = _lipstickService.CreateLipsticktInput();
                            _productRepository.Add(lipstick);
                        }

                    }
                    void EditProduct()
                    {
                        _productRepository.GetProducts();
                    }
                    void ShowProduct()
                    {
                        foreach (var item in _productRepository.GetProducts())
                        {
                            Console.WriteLine(item);
                        }

                    }
            }

        }

    }
    // Eine andere Klasse, die die Methode des Interfaces aufruft

    //    UserChoice GetUserChoice()
    //    {
    //        // Erstellen Sie eine Instanz von MyClass
    //        UserChoice myInstance = new UserChoice();
    //        string userChoiceOne = myInstance.choiceOne();
    //        decimal userChoiceTwo = myInstance.choiceTwo();

    //    }
    //}
}

//var products = _saveLoad.JsonLoad();
//_repository.AddRange(products);
//_inputService.ConsoleInput();
//_saveLoad.JsonSave(products);

//        while (true)
//        {
//            DisplayUserOptions();
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    _inputService.AddProduct();
//                    break;
//                //case "2":
//                //    Show();
//                    break;
//                //case "3":
//                //    Edit();
//                //    break;
//                //case "4":
//                //    Delete();
//                //    break;
//                //case "5":
//                //    Close();
//                //    break;
//                default:
//                    Console.WriteLine("Sorry, wrong input");
//                    break;
//            }

//            Console.WriteLine("\n");
//        }

//         static void AddProduct() 
//        {
//            InputService inputService = new InputService();
//            inputService.AddProduct();

//        }
//    }

//    private static void DisplayUserOptions()
//    {
//        Console.WriteLine("Hey! Welcome to our Douglas Prodcut Management Site.");
//        Console.WriteLine("1: Add a product");
//        Console.WriteLine("2: Show a product");
//        Console.WriteLine("3: Edit a product");
//        Console.WriteLine("4: Delete a product");
//        Console.WriteLine("5: Close the Product Manager");

//        Console.WriteLine("Choose an option: ");
//    }



//}

//    public static void Addd()//
//    {
//        Console.WriteLine("Enter L for Lipstick or P for Perfume: ");
//        string userChoice = Console.ReadLine();

//        if (userChoice == "L")

//        {
//            Lipstick lipstick = new Lipstick();
//            lipstick.AddTo();
//            lipstick.WriteToConsole();
//            product.Add(lipstick);
//        }
//        else if (userChoice == "P")
//        {
//            var perfume = new Perfume();
//            perfume.questionsAdd();
//            perfume.WriteToConsole();
//            products.Add(perfume);
//        }

//        else
//        {
//            Console.WriteLine("Invalid Input");
//        }
//    }

//    public static void Show()
//    {
//        foreach (var product in _repository.GetProducts())
//        {
//            Console.WriteLine(product);
//        }
//    }
//}

//public static void Edit()//
//{
//    Show();

//    Console.WriteLine("Please choose item to edit (input position number): ");
//    var position = Convert.ToInt32(Console.ReadLine());

//    if (position == 0 || position > products.Count)
//    {
//        Console.WriteLine("This position is not allowed");
//        Edit();
//    }

//    var elementToEdit = products[position - 1];
//    elementToEdit.questionsAdd();
//}

//public static void Delete()//
//{
//    Show();

//    Console.WriteLine("Please choose item to delete (input position number): ");
//    var position = Convert.ToInt32(Console.ReadLine());

//    if (position == 0 || position > _repository.Count)
//    {
//        Console.WriteLine("This position is not allowed");
//        Edit();
//    }

//    var elementToDelete = products[position - 1];

//    products.Remove(elementToDelete);

//    Console.WriteLine("The product has been successfully deleted\n");
//}

//static void Close()
//{
//    var save = new JsonSave(products);
//    Environment.Exit(0);
//}
//}
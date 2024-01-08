using ProductManagement.Classes.Products;
using ProductManagement.Interfaces;

namespace ProductManagement.Classes.Services;

public class InputService : IInputService
{
    private IProductRepository _productRepository;

    public InputService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    private readonly ILipstickService lipstickservice;

    public InputService(ILipstickService lipstickService)
    {
        this.lipstickservice = lipstickservice;
    }

    public Product CreateProductInput(Product product)
    {
        Console.WriteLine("Please enter the brand: ");
        product.ProductBrand = Console.ReadLine();

        Console.WriteLine("Please enter the name: ");
        product.ProductName = Console.ReadLine();

        Console.WriteLine("Please enter the definition: ");
        product.ProductDefinition = Console.ReadLine();

        Console.WriteLine("Please enter the price: ");
        product.ProductPrice = Convert.ToDecimal(Console.ReadLine());

        return product;

    }


    //    private static IUserChoice _userChoice = new UserChoice();

    //    public InputService(IUserChoice userChoice)
    //    {
    //        _userChoice = userChoice;
    //    }
    //    public void AddInput()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IProduct CreateProduct()
    //    {
    //        Console.WriteLine("Enter L for Lipstick or P for Perfume: ");
    //        string userChoice = Console.ReadLine();
    //        Product product;

    //        if (userChoice == "L")
    //        {
    //            Lipstick lipstick = new Lipstick();
    //            lipstick = (Lipstick)ConsoleInput();
    //            product = lipstick;
    //            return lipstick;

    //        }
    //        else if (userChoice == "P")
    //        {
    //            var perfume = new Perfume();
    //            perfume = (Perfume)ConsoleInput();
    //            product = perfume;
    //            return product;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid Input");
    //            return null;
    //        }
    //        return product;
    //    }
    public void DisplayUserOptions()
    {
        Console.WriteLine("Hey! Welcome to our Douglas Prodcut Management Site.");
        Console.WriteLine("1: Add a product");
        Console.WriteLine("2: Show a product");
        Console.WriteLine("3: Edit a product");
        Console.WriteLine("4: Delete a product");
        Console.WriteLine("5: Close the Product Manager");
        Console.WriteLine("Choose an option: ");
        UserChoice userChoice = new UserChoice();

    }



    public Product EditProduct(IList<Product> products)
    {
        Console.WriteLine("Please choose item to edit (input position number): ");
        var position = Convert.ToInt32(Console.ReadLine());

        if (position == 0 || position > products.Count)
        {
            Console.WriteLine("This position is not allowed");
        }
        var elementToEdit = products[position - 1];
        //elementToEdit = new Lipstick();

        if (elementToEdit is Product product && this.lipstickservice != null && elementToEdit.ProductCategory == "Lipstick")
        {
            _productRepository.Remove(elementToEdit);
            var editedLipstick = (Product)this.lipstickservice.CreateLipsticktInput();
            _productRepository.Add(editedLipstick);
            //elementToEdit = (Lipstick)this.CreateProductInput(elementToEdit);
            //elementToEdit.

        }
        return elementToEdit;
        //_products.Add(elementToEdit);

        //void IInputService.DisplayUserOptions()
        //{
        //    throw new NotImplementedException();
        //}
    }


}
//public void CreateProductInput()
//{
//    //var product = new Product();
//    //var userChoice = new UserChoice();

//    Console.WriteLine("Please enter the category: ");
//    string productCategory = Console.ReadLine();

//    Console.WriteLine("Please enter the brand: ");
//    string productBrand = Console.ReadLine();

//    Console.WriteLine("Please enter the name: ");
//    string productName = Console.ReadLine();

//    Console.WriteLine("Please enter the definition: ");
//    string productDefinition = Console.ReadLine();

//    Console.WriteLine("Please enter the price: ");
//    decimal productPrice = Convert.ToDecimal(Console.ReadLine());

//    //return product;
//}

//    public Product DeleteInput(IList<Product> products)
//    {
//        Console.WriteLine("Please choose item to delete (input position number): ");
//        var position = Convert.ToInt32(Console.ReadLine());
//        if (position == 0 || position > products.Count)
//        {
//            Console.WriteLine("This position is not allowed");
//        }
//        var elementToDelete = products[position - 1];
//        products.Remove(elementToDelete);
//        Console.WriteLine("The product has been successfully deleted\n");
//        return elementToDelete;

//    }



//    public decimal choiceTwo()
//    {
//        return choiceTwo();
//    }

//    public string choiceOne()
//    {
//        return choiceOne();
//    }
//    _______________________________________________


//    //void ConsoleInput()
//    //{
//    //    throw new NotImplementedException();
//    //}
//}

////    public Lipstick ConsoleInput(string colour)
////    {   var lipstick = new Lipstick();
////        Console.WriteLine("Please enter the colour: ");
////        lipstick.ProductColour = Console.ReadLine();
////        return lipstick;
////    }

////    public void EditProduct()
////    {
////        throw new NotImplementedException();
////    }
////}    //public Product ConsoleInput()
////{
////    var product = new Product();

////    Console.WriteLine("Please enter the category: ");
////    product.ProductCategory = Console.ReadLine();

////    Console.WriteLine("Please enter the brand: ");
////    product.ProductBrand = Console.ReadLine();

////    Console.WriteLine("Please enter the name: ");
////    product.ProductName = Console.ReadLine();

////    Console.WriteLine("Please enter the definition: ");
////    product.ProductDefinition = Console.ReadLine();

////    Console.WriteLine("Please enter the price: ");
////    product.ProductPrice = Convert.ToDecimal(Console.ReadLine());

////    return product;
////}

////public dynamic AddProduct()
////{
////    Console.WriteLine("Enter L for Lipstick or P for Perfume: ");
////    string userChoice = Console.ReadLine();
////    Product product;

////    if (userChoice == "L")
////    {
////        Lipstick lipstick = new Lipstick();
////        lipstick = (Lipstick)ConsoleInput();
////        product = lipstick;
////        return product;

////    }
////    else if (userChoice == "P")
////    {
////        var perfume = new Perfume();
////        perfume = (Perfume)ConsoleInput();
////        product = perfume;
////        return product;
////    }
////    else
////    {
////       Console.WriteLine("Invalid Input");
////        return null;
////    }
////}

////public void EditProduct()
////{
////    List<Product> products = new List<Product>();

////    Console.WriteLine("Please choose item to edit (input position number): ");
////    var position = Convert.ToInt32(Console.ReadLine());

////    if (position == 0 || position >= products.Count)
////    {
////        Console.WriteLine("This position is not allowed");
////    }

////    var elementToEdit = products[position - 1];
////}



////public void DeleteProduct()
////{
////    List<Product> products = new List<Product>();

////    {
////        Console.WriteLine("Please choose item to delete (input position number): ");
////        var position = Convert.ToInt32(Console.ReadLine());

////        if (position == 0 || position > products.Count)
////        {
////            Console.WriteLine("This position is not allowed");
////        }

////        var elementToDelete = products[position - 1];

////        products.Remove(elementToDelete);

////        Console.WriteLine("The product has been successfully deleted\n");
////    }
////}



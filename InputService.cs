public class InputService : IInputService
{
    public Product ConsoleInput()
    {
        var product = new Product();

        Console.WriteLine("Please enter the category: ");
        product.ProductCategory = Console.ReadLine();

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

    public void AddProduct()
    {
        var product = new Product();

        Console.WriteLine("Enter L for Lipstick or P for Perfume: ");
        string userChoice = Console.ReadLine();

        if (userChoice == "L")

        {
            Lipstick lipstick = new Lipstick();
            product = lipstick;

        }
        else if (userChoice == "P")
        {
            var perfume = new Perfume();
            product = perfume;
        }

        else
        {
            Console.WriteLine("Invalid Input");
        }
    }

    public void EditProduct()
    {
        List<Product> products = new List<Product>();

        Console.WriteLine("Please choose item to edit (input position number): ");
        var position = Convert.ToInt32(Console.ReadLine());

        if (position == 0 || position >= products.Count)
        {
            Console.WriteLine("This position is not allowed");
        }

        var elementToEdit = products[position - 1];
    }

    public void DeleteProduct()
    {
        {
            Console.WriteLine("Please choose item to delete (input position number): ");
            var position = Convert.ToInt32(Console.ReadLine());

            if (position == 0 || position > products.Count)
            {
                Console.WriteLine("This position is not allowed");
            }

            var elementToDelete = products[position - 1];

            products.Remove(elementToDelete);

            Console.WriteLine("The product has been successfully deleted\n");
        }
    }
}



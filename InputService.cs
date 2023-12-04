using System;

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
}

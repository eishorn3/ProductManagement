namespace ProductManagement;

public class PerfumeService : IPerfumeService
{

    public PerfumeService()
    {
    }

    public Perfume CreatePerfumeInput()
    {
        var perfume = new Perfume();

        Console.WriteLine("Please enter the brand: ");
        perfume.ProductBrand = Console.ReadLine();

        Console.WriteLine("Please enter the name: ");
        perfume.ProductName = Console.ReadLine();

        Console.WriteLine("Please enter the definition: ");
        perfume.ProductDefinition = Console.ReadLine();

        Console.WriteLine("Please enter the price: ");
        perfume.ProductPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the scent: ");
        perfume.ProductScent = Console.ReadLine();

        return perfume;
    }

    public void EditPerfumeInput(Perfume perfume)
    {
        Console.WriteLine("Please enter the brand: ");
        perfume.ProductBrand = Console.ReadLine();

        Console.WriteLine("Please enter the name: ");
        perfume.ProductName = Console.ReadLine();

        Console.WriteLine("Please enter the definition: ");
        perfume.ProductDefinition = Console.ReadLine();

        Console.WriteLine("Please enter the price: ");
        perfume.ProductPrice = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the scent: ");
        perfume.ProductScent = Console.ReadLine();
    }
}
[Serializable]
public class Lipstick : Product, IProduct, ILipstickService
{
    public string? ProductColour { get; set; }

    //public void AddProduct()
    //{
    //    throw new NotImplementedException();
    //}

    //override Product ConsoleInput()
    //{

    //}
    public Lipstick CreateLipsticktInput()
    {
        var lipstick = new Lipstick();

        Console.WriteLine("Please enter the colour: ");
        lipstick.ProductColour = Console.ReadLine();

        return lipstick;
    }
    //public Lipstick CreateLipsticktInput()
    //{
    //    var lipstick = new Lipstick();

    //    //Console.WriteLine("Please enter the category: ");
    //    //lipstick.ProductCategory = Console.ReadLine();

    //    //Console.WriteLine("Please enter the brand: ");
    //    //lipstick.ProductBrand = Console.ReadLine();

    //    //Console.WriteLine("Please enter the name: ");
    //    //lipstick.ProductName = Console.ReadLine();

    //    //Console.WriteLine("Please enter the definition: ");
    //    //lipstick.ProductDefinition = Console.ReadLine();

    //    //Console.WriteLine("Please enter the price: ");
    //    //lipstick.ProductPrice = Convert.ToDecimal(Console.ReadLine());

    //    Console.WriteLine("Please enter the colour: ");
    //    lipstick.ProductColour = Console.ReadLine();

    //    return lipstick;
    //}


}
//    _______________________________________________________________
//    //public void EditProduct()
//    //{
//    //    throw new NotImplementedException();
//    //}

//    //public override string ToString()
//    //{
//    //    return base.ToString() + $"\tProductColour: {ProductColour}\n";
//    //}

//    //dynamic IInputService.AddProduct()
//    //{
//    //    throw new NotImplementedException();
//    //}

//    //public override void questionsAdd()
//    //{
//    //    base.questionsAdd();
//    //    Console.WriteLine("Please enter the new colour: ");
//    //    string productColour = Console.ReadLine();
//    //    ProductColour = productColour;

//    //}


//}
[Serializable]
public class Lipstick : Product
{
    public string? ProductColour { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"\tProductColour: {ProductColour}\n";
    }

    //public override void questionsAdd()
    //{
    //    base.questionsAdd();
    //    Console.WriteLine("Please enter the new colour: ");
    //    string productColour = Console.ReadLine();
    //    ProductColour = productColour;

    //}

}
﻿public class UserChoice : IUserChoice
{
    public string choiceOne()
    {
        Console.WriteLine("Please enter L or P");
        string choiceOne = Console.ReadLine();
        return choiceOne;
    }

    public decimal choiceTwo()
    {
        Console.WriteLine("Please enter a number");
        decimal choiceOne = Convert.ToDecimal(Console.ReadLine());
        return choiceOne;
    }
}

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductManagement 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! Welcome to our Douglas Prodcut Management Site.");

            string[] lipstickBrand = {"Douglas", "Chanel", "Dior"};
            Array.ForEach(lipstickBrand, Console.WriteLine);

            string[] lipstickName = { "Mirror Shine", "Rouge Allure", "Dior Addict" };
            Array.ForEach(lipstickName, Console.WriteLine);

            string[] lipstickColour = { "Tease Me", "Pirate", "Vinyl Red" };
            Array.ForEach(lipstickColour, Console.WriteLine);

            double[] lipstickPrice = { 12.99, 45.83, 44.49 };
            Array.ForEach(lipstickPrice, Console.WriteLine);

            string[,] lipsticks = {
                { "Douglas", "Mirror Shine", "Tease Me", "12.99" },
                { "Chanel", "Mirror Shine", "Pirate", "45.83" },
                {"Dior", "Dior Addict", "Vinyl Red", "44.49" }
            };

            Console.WriteLine("Brand:");
            string userInputBrand = Console.ReadLine();
            string[] newLipstickBrand = lipstickBrand.Concat(new string[] { userInputBrand }).ToArray();
            lipstickBrand = newLipstickBrand;
            Array.ForEach(lipstickBrand, Console.WriteLine);
     



        }
    }
}
using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductManagement


{
    internal class Program
    {
        static List<string> lipstickBrands = new List<string>();
        static List<string> lipstickNames = new List<string>();
        static List<string> lipstickColours = new List<string>();
        static List<decimal> lipstickPrices = new List<decimal>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Hey! Welcome to our Douglas Prodcut Management Site.");
                Console.WriteLine("1: Add a product");
                Console.WriteLine("2: Show a product");
                Console.WriteLine("3: Edit a product");
                Console.WriteLine("4: Delete a product");
                Console.WriteLine("5: Close the Product Manager");

                Console.WriteLine("Choose an option: ");



                string choice = Console.ReadLine();




                switch (choice)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Show();
                        break;
                    //case "3":
                    //    Edit();
                    //    break;
                    //case "4":
                    //    Delete();
                    //    break;
                    //case "5":
                    //    Close();
                    //    break;
                    default:
                        Console.WriteLine("Sorry, wrong input");
                        break;
                }
            }



            //static void Edit()
            //{
            //    Console.WriteLine
            //}


            //    string[] lipstickBrand = { "Douglas", "Chanel", "Dior" };
            //    Array.ForEach(lipstickBrand, Console.WriteLine);

            //    string[] lipstickName = { "Mirror Shine", "Rouge Allure", "Dior Addict" };
            //    Array.ForEach(lipstickName, Console.WriteLine);

            //    string[] lipstickColour = { "Tease Me", "Pirate", "Vinyl Red" };
            //    Array.ForEach(lipstickColour, Console.WriteLine);

            //    double[] lipstickPrice = { 12.99, 45.83, 44.49 };
            //    Array.ForEach(lipstickPrice, Console.WriteLine);

            //    string[,] lipsticks = {
            //        { "Douglas", "Mirror Shine", "Tease Me", "12.99" },
            //        { "Chanel", "Mirror Shine", "Pirate", "45.83" },
            //        {"Dior", "Dior Addict", "Vinyl Red", "44.49" }
            //    };

            //    Console.WriteLine("Brand:");
            //    string userInputBrand = Console.ReadLine();
            //    string[] newLipstickBrand = lipstickBrand.Concat(new string[] { userInputBrand }).ToArray();
            //    lipstickBrand = newLipstickBrand;
            //    Array.ForEach(lipstickBrand, Console.WriteLine);
            //}

            //public record Lipstick(string BrandName, string Colour, string LipstickName, double LipstickPrice);
            //public static void Main()
            //{
            //    Lipstick lipstick = new("Chanel", "FuriousRed", "Passionista", 15.88); //prints but in arraystyle
            //    Console.WriteLine(lipstick);
            //}

            //public record Lipsticks
            //{
            //    public required string BrandName { get; set; }
            //    public required string ColourName { get; set; }
            //};

        }


        static void Add()
        {
            Console.WriteLine("Please enter the brand: ");
            string liptstickBrand = Console.ReadLine();

            lipstickBrands.Add(liptstickBrand);

            Console.WriteLine("Please enter the name: ");
            string liptstickName = Console.ReadLine();

            lipstickNames.Add(liptstickName);

            Console.WriteLine("Please enter the colour: ");
            string liptstickColour = Console.ReadLine();

            lipstickColours.Add(liptstickColour);

            Console.WriteLine("Please enter the price: ");
            decimal lipstickPrice = Convert.ToDecimal(Console.ReadLine());

            lipstickPrices.Add(lipstickPrice);


        }

        static void ShowLinq()
        {
            lipstickNames.ForEach(x => { Console.WriteLine(x); });
        }

        static void ShowForEach()
        {
            foreach (var l in lipstickPrices)
            {
                Console.WriteLine(l.ToString());
            }
        }

        static void Showfor()
        {
            for (int i = 0; i < lipstickNames.Count; i++)
            {
                Console.WriteLine(lipstickNames[i]);
            }
        }

        static void Showcontainswhile()
        {
            int length = lipstickBrands.Count;
            int position = 0;

            while (position < length)
            {
                Console.WriteLine(lipstickBrands[position]);
                position++;
            }
        }

    }

}
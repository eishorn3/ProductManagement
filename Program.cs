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
                    case "3":
                        Edit();
                        break;
                    case "4":
                        Delete();
                        break;
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


            //static void ShowLinq()
            //{
            //    lipstickNames.ForEach(x => { Console.WriteLine(x); });
            //}

            //static void Showfor()
            //{
            //    for (int i = 0; i < lipstickNames.Count; i++)
            //    {
            //        Console.WriteLine(lipstickNames[i]);
            //    }
            //}

            //static void Showcontainswhile()
            //{
            //    int length = lipstickBrands.Count;
            //    int position = 0;

            //    while (position < length)
            //    {
            //        Console.WriteLine(lipstickBrands[position]);
            //        position++;
            //    }
            //}

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

        static void Show()
        {
            foreach (var l in lipstickBrands)
            {
                Console.WriteLine(l);
            }

            foreach (var l in lipstickNames)
            {
                Console.WriteLine(l);
            }

            foreach (var l in lipstickColours)
            {
                Console.WriteLine(l);
            }

            foreach (var l in lipstickPrices)
            {
                Console.WriteLine(l.ToString());
            }

        }

        static void Edit()
        {
            Console.WriteLine("Please, enter the brand you want to edit: ");
            string editInputBrand = Console.ReadLine();
            if (editInputBrand == lipstickBrands[0])
            {   Console.WriteLine("Enter the new brand: ");
                string newLipstickBrand = Console.ReadLine();
                //lipstickBrands.Remove(editInputBrands);
                //lipstickBrands.Add(newLipstickBrand);
                //lipstickBrand = lipstickBrand.Replace(editInputBrands, newLipstickBrand);
                //List<string>LipstickBrands.Replace(editInputBrands, newLipstickBrand);
                lipstickBrands[0] = newLipstickBrand;
            }
            Console.WriteLine("Please, enter the name you want to edit: ");
            string editInputName = Console.ReadLine();
            if (editInputName == lipstickNames[0])
            {
                Console.WriteLine("Enter the new name: ");
                string newLipstickName = Console.ReadLine();
                lipstickNames[0] = newLipstickName;
            }
            Console.WriteLine("Please, enter the colour you want to edit: ");
            string editInputColour = Console.ReadLine();
            if (editInputColour == lipstickColours[0])
            {
                Console.WriteLine("Enter the new colour: ");
                string newLipstickColour = Console.ReadLine();
                lipstickColours[0] = newLipstickColour;
            }

            Console.WriteLine("Please, enter the price you want to edit: ");
            decimal editInputPrice = Convert.ToDecimal(Console.ReadLine());
            if (editInputPrice == lipstickPrices[0])
            {
                Console.WriteLine("Enter the new brand: ");
                decimal newLipstickPrice = Convert.ToDecimal(Console.ReadLine());
                lipstickPrices[0] = newLipstickPrice;
            }
        }
        static void Delete()
        {
            Console.WriteLine("Please, enter the brand: ");
            string removeInputBrands = Console.ReadLine();

            if (removeInputBrands == lipstickBrands[0])
            {
                
                lipstickBrands.Remove(removeInputBrands);

            }

            Console.WriteLine("Please, enter the name: ");
            string removeInputNames = Console.ReadLine();
            if (removeInputNames == lipstickNames[0])
            {
                lipstickNames.Remove(removeInputNames);

            }

            Console.WriteLine("Please, enter the colour: ");
            string removeInputColours = Console.ReadLine();
            if (removeInputColours == lipstickColours[0])
            {
                lipstickColours.Remove(removeInputColours);

            }

            Console.WriteLine("Please, enter the price: ");
            decimal removeInputPrices = Convert.ToDecimal(Console.ReadLine());
            if (removeInputPrices == lipstickPrices[0])
            {
                lipstickPrices.Remove(removeInputPrices);

            }

        }

    }
}
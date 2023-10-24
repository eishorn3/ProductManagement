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
        static List<LipstickProduct> products = new List<LipstickProduct>();

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

                Console.WriteLine("\n");
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

            Console.WriteLine("Please enter the name: ");
            string liptstickName = Console.ReadLine();

            Console.WriteLine("Please enter the colour: ");
            string liptstickColour = Console.ReadLine();

            Console.WriteLine("Please enter the price: ");
            decimal lipstickPrice = Convert.ToDecimal(Console.ReadLine());

            var product = new LipstickProduct(liptstickName, liptstickBrand, liptstickColour, lipstickPrice);
            product.WriteToConsole();

            products.Add(product);

        }

        static void Show()
        {
            foreach (var product in products)
            {
                product.WriteToConsole();
            }
        }

        static void Edit()
        {
            Show();

            Console.WriteLine("Please choose item to edit (input position number): ");
            var position = Convert.ToInt32(Console.ReadLine());

            if (position == 0 || position > products.Count)
            {
                Console.WriteLine("This position is not allowed");
                Edit();
            }

            var elementToEdit = products[position - 1];

            Console.WriteLine("Please enter the new brand: ");
            string liptstickBrand = Console.ReadLine();

            Console.WriteLine("Please enter the new name: ");
            string liptstickName = Console.ReadLine();

            Console.WriteLine("Please enter the new colour: ");
            string liptstickColour = Console.ReadLine();

            Console.WriteLine("Please enter the new price: ");
            decimal lipstickPrice = Convert.ToDecimal(Console.ReadLine());

            elementToEdit.LipstickName = liptstickName;
            elementToEdit.LipstickBrand = liptstickBrand;
            elementToEdit.LipstickColour = liptstickColour;
            elementToEdit.LipstickPrice = lipstickPrice;
        }

        //static void Delete()
        //{
        //    Console.WriteLine("Please, enter the brand: ");
        //    string removeInputBrands = Console.ReadLine();

        //    if (removeInputBrands == lipstickBrands[0])
        //    {

        //        lipstickBrands.Remove(removeInputBrands);

        //    }

        //    Console.WriteLine("Please, enter the name: ");
        //    string removeInputNames = Console.ReadLine();
        //    if (removeInputNames == lipstickNames[0])
        //    {
        //        lipstickNames.Remove(removeInputNames);

        //    }

        //    Console.WriteLine("Please, enter the colour: ");
        //    string removeInputColours = Console.ReadLine();
        //    if (removeInputColours == lipstickColours[0])
        //    {
        //        lipstickColours.Remove(removeInputColours);

        //    }

        //    Console.WriteLine("Please, enter the price: ");
        //    decimal removeInputPrices = Convert.ToDecimal(Console.ReadLine());
        //    if (removeInputPrices == lipstickPrices[0])
        //    {
        //        lipstickPrices.Remove(removeInputPrices);

        //    }

        //}

    }

}
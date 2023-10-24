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
                    case "4":
                        Delete();
                        break;
                    case "5":
                        Close();
                        break;
                    default:
                        Console.WriteLine("Sorry, wrong input");
                        break;
                }

                Console.WriteLine("\n");
            }




        }


        static void Add()
        {

            Console.WriteLine("Please enter the brand: ");
            string lipstickBrand = Console.ReadLine();

            Console.WriteLine("Please enter the name: ");
            string lipstickName = Console.ReadLine();

            Console.WriteLine("Please enter the colour: ");
            string lipstickColour = Console.ReadLine();

            Console.WriteLine("Please enter the price: ");
            decimal lipstickPrice = Convert.ToDecimal(Console.ReadLine());

            var product = new LipstickProduct(lipstickName, lipstickBrand, lipstickColour, lipstickPrice);
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
            string lipstickBrand = Console.ReadLine();

            Console.WriteLine("Please enter the new name: ");
            string lipstickName = Console.ReadLine();

            Console.WriteLine("Please enter the new colour: ");
            string lipstickColour = Console.ReadLine();

            Console.WriteLine("Please enter the new price: ");
            decimal lipstickPrice = Convert.ToDecimal(Console.ReadLine());

            elementToEdit.LipstickName = lipstickName;
            elementToEdit.LipstickBrand = lipstickBrand;
            elementToEdit.LipstickColour = lipstickColour;
            elementToEdit.LipstickPrice = lipstickPrice;
        }

        static void Delete()
        {
            Show();

            Console.WriteLine("Please choose item to delete (input position number): ");
            var position = Convert.ToInt32(Console.ReadLine());

            if (position == 0 || position > products.Count)
            {
                Console.WriteLine("This position is not allowed");
                Edit();
            }

            var elementToDelete= products[position - 1];

            products.Remove(elementToDelete);

        
            Console.WriteLine("The product has been successfully deleted\n");
            

        }

        static void Close()
        {
            Environment.Exit(0);
        }

    }

}
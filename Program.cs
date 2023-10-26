using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductManagement


{
    public class Program
    {
        static List<Product> products = new List<Product>();
        static List<Lipstick> lipstickproducts = new List<Lipstick>();
        static List<Perfume> perfumeproducts = new List<Perfume>();


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
                    case "´5":
                        Close();
                        break;
                    default:
                        Console.WriteLine("Sorry, wrong input");
                        break;
                }

                Console.WriteLine("\n");
            }




        }
        // User muss Auswahl zwischen Lippenstift oder Parfum auswählen
        //Cases müssen seperat ablaufen
        //static void Choose()
        //{
        //    string userChoice = Console.ReadLine();
        //    if (userChoice == "Lipstick")
        //    {

        //    }
        //    else if (userChoice == "Perfume")
        //    { }
        //    else
        //    { };



        //}

        public static void Add()
        {
            Console.WriteLine("Enter L for Lipstick or P for Perfume: ");
            string userChoiceLipstick = "L";
            string userChoicePerfume = "P";
            string userChoice = Console.ReadLine();
            
            if (userChoice == userChoiceLipstick)

            {
                var lipstickproduct = new Lipstick();
                lipstickproduct.questionsAddLipstick();
                
                //var lipstickproduct = new Lipstick(productCategory, productBrand, productName, productDefinition, productPrice, productColour);
                lipstickproduct.LipstickWriteToConsole();
                lipstickproducts.Add(lipstickproduct);



            }
            else if (userChoice == userChoicePerfume)
            {
                Console.WriteLine("Please enter the brand: ");
                string productBrand = Console.ReadLine();

                Console.WriteLine("Please enter the name: ");
                string productName = Console.ReadLine();

                Console.WriteLine("Please enter the definition: ");
                string productDefinition = Console.ReadLine();

                Console.WriteLine("Please enter the price: ");
                decimal productPrice = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the scent: ");
                string productScent = Console.ReadLine();

                var perfumeproduct = new Perfume();
                perfumeproduct.questionsAddPerfume();
                perfumeproduct.WriteToConsole();

                perfumeproducts.Add(perfumeproduct);
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }

        }

        static void Show()
        {
            foreach (var product in products)
            {
                product.WriteToConsole();
            }
                foreach (var lipstickproduct in lipstickproducts)
                {
                    lipstickproduct.WriteToConsole();
                }

                foreach (var perfumeproduct in perfumeproducts)
                {
                    perfumeproduct.WriteToConsole();
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
            string productBrand = Console.ReadLine();

            Console.WriteLine("Please enter the new name: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Please enter the new colour: ");
            string productColour = Console.ReadLine();

            Console.WriteLine("Please enter the new definition: ");
            string productDefinition = Console.ReadLine();

            Console.WriteLine("Please enter the new price: ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            elementToEdit.ProductName = productName;
            elementToEdit.ProductBrand = productBrand;
            elementToEdit.ProductDefinition = productDefinition;
            elementToEdit.ProductPrice = productPrice;
            //elementToEdit.ProductColour = productColour;

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
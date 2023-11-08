﻿using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace ProductManagement


{
    public class Program
    {
        static List<Product> products = new List<Product>();

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
                Console.WriteLine("6: Save Changes");
                Console.WriteLine("7: Load Products");


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
                    case "6":
                        Save();
                        break;
                    case "7":
                        Load();
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
                products.Add(lipstickproduct);





            }
            else if (userChoice == userChoicePerfume)
            {

                var perfumeproduct = new Perfume();
                perfumeproduct.questionsAddPerfume();
                perfumeproduct.WriteToConsole();

                products.Add(perfumeproduct);
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

            if (elementToEdit is Lipstick lipstickproduct)
            {
                lipstickproduct.questionsAddLipstick();
            }
            else if (elementToEdit is Perfume perfumeproduct)
            {
                perfumeproduct.questionsAddPerfume();
            }
            else {
                /*
                 * TODO
                 * Hier werden nur die Properties von der Mutterklasse Product erfasst.
                 * Wie könnte man hier die spezifischen Properties ebenfalls erfassen?
                 * Tipp: Typprüfung
                 */

                elementToEdit.questionsAdd();
            }
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

            var elementToDelete = products[position - 1];

            products.Remove(elementToDelete);


            Console.WriteLine("The product has been successfully deleted\n");


        }
        static void Save()
        {
#pragma warning disable SYSLIB0011

            FileStream stream = new FileStream(@"C:\Users\j.glomb\Documents\ProductFiles\productobjects.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, products);
            stream.Close();


        }
        static void Load()
        {
            object productLoad = null;
            FileStream filestream;
            BinaryFormatter formatter = new BinaryFormatter();

            filestream = File.OpenRead(@"C:\Users\j.glomb\Documents\ProductFiles\productobjects.txt");
            productLoad = formatter.Deserialize(filestream);
            filestream.Close();
        }
                static void Close()
        {
            Environment.Exit(0);
        }



    }

}
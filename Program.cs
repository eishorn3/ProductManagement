using System.Runtime.Serialization.Formatters.Binary;

namespace ProductManagement


{
    public class Program
    {
        public static List<Product> products = new List<Product>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Load();
                DisplayUserOptions();
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
                        Save();
                        break;
                    case "6":
                        Load();
                        break;
                    case "7":
                        JSONSave();
                        break;
                    case "8":
                        JSONLoad();
                        break;
                    case "9":
                        Close();
                        break;
                    default:
                        Console.WriteLine("Sorry, wrong input");
                        break;
                }

                Console.WriteLine("\n");
            }
        }

        private static void DisplayUserOptions()
        {
            Console.WriteLine("Hey! Welcome to our Douglas Prodcut Management Site.");
            Console.WriteLine("1: Add a product");
            Console.WriteLine("2: Show a product");
            Console.WriteLine("3: Edit a product");
            Console.WriteLine("4: Delete a product");
            Console.WriteLine("5: Close the Product Manager");
            Console.WriteLine("6: Save Changes");
            Console.WriteLine("7: Load Products");
            Console.WriteLine("8: Save Changes in JSON");
            Console.WriteLine("9: Load Products from JSON");

            Console.WriteLine("Choose an option: ");
        }

        public static void Add()
        {

            Console.WriteLine("Enter L for Lipstick or P for Perfume: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "L")

            {
                var lipstickproduct = new Lipstick();
                lipstickproduct.questionsAdd();
                lipstickproduct.WriteToConsole();
                products.Add(lipstickproduct);
            }
            else if (userChoice == "P")
            {
                var perfumeproduct = new Perfume();
                perfumeproduct.questionsAdd();
                perfumeproduct.WriteToConsole();
                products.Add(perfumeproduct);
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public static void Show()
        {
            foreach (var product in products)
            {
                product.WriteToConsole();
            }
        }

        public static void Edit()
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

            if (elementToEdit is Lipstick lipstickproduct || elementToEdit is Perfume perfumeproduct)
            {
                elementToEdit.questionsAdd();
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public static void Delete()
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
        public static void Save()
        {
#pragma warning disable SYSLIB0011

            FileStream stream = new FileStream(@"C:\Users\j.glomb\Documents\ProductFiles\productobjects.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, products);
            stream.Close();



        }
        public static void Load()
        {
            FileStream filestream = File.OpenRead(@"C:\Users\j.glomb\Documents\ProductFiles\productobjects.txt");
            BinaryFormatter formatter = new BinaryFormatter();
            products = (List<Product>)formatter.Deserialize(filestream);
            filestream.Close();
            Show();
        }
        static void Close()
        {
            Environment.Exit(0);
        }

        public static void JSONSave()
        {
            {
                File.WriteAllText("newy.json", System.Text.Json.JsonSerializer.Serialize(products));
            }

        }

        public static void JSONLoad()
        {
            var products2 = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(File.ReadAllText("newy.json"));
            foreach (var item in products2)
            {
                item.WriteToConsole();
            }

            products = products2;
        }

    }
}
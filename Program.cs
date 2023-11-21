using System.Runtime.Serialization.Formatters.Binary;

namespace ProductManagement


{
    public class Program
    {
        public static List<Product> products = new List<Product>();

        public static void Main(string[] args)
        {
            while (true)
                CasesForUserChoice();
        }

        private static void CasesForUserChoice()
        {
            string choice = DisplayUserOptionsGetsChoice();

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

        private static string DisplayUserOptionsGetsChoice()
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

            string choice = Console.ReadLine();
            return choice;
        }

        public static void Add()
        {
            GetProductInformation();
        }

        private static void GetProductInformation()
        {
            string userChoiceLipstick = "L";
            string userChoicePerfume = "P";


            var lipstickproduct = new Lipstick();
            var perfumeproduct = new Perfume();

            Console.WriteLine("Enter L for Lipstick or P for Perfume: ");

            string userChoice = Console.ReadLine();

            if (userChoice == userChoiceLipstick)

            {
                lipstickproduct.questionsAdd();
                lipstickproduct.WriteToConsole();
                products.Add(lipstickproduct);

            }
            else if (userChoice == userChoicePerfume)
            {
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
            DisplayEachProduct();
        }

        private static void DisplayEachProduct()
        {
            foreach (var product in products)
            {
                product.WriteToConsole();
            }
        }

        public static void Edit()
        {
            ChooseProductToEdit();
        }

        private static void ChooseProductToEdit()
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
            ChooseProductToDelete();
        }

        private static void ChooseProductToDelete()
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
            BinarySavingToLocalFile();

        }

        private static void BinarySavingToLocalFile()
        {
#pragma warning disable SYSLIB0011

            FileStream stream = new FileStream(@"C:\Users\j.glomb\Documents\ProductFiles\productobjects.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, products);
            stream.Close();
        }

        public static void Load()
        {
            BinaryLoadingFromLocalFile();
        }

        private static void BinaryLoadingFromLocalFile()
        {
            FileStream filestream = File.OpenRead(@"C:\Users\j.glomb\Documents\ProductFiles\productobjects.txt");
            BinaryFormatter formatter = new BinaryFormatter();
            products = (List<Product>)formatter.Deserialize(filestream);
            filestream.Close();
            Show();
        }

        static void Close()
        {
            EndsProgram();
        }

        private static void EndsProgram()
        {
            Environment.Exit(0);
        }

        public static void JSONSave()
        {
            JsonSavingToLocalFile();

        }

        private static void JsonSavingToLocalFile()
        {
            File.WriteAllText("newy.json", System.Text.Json.JsonSerializer.Serialize(products));
        }

        public static void JSONLoad()
        {
            JsonLoadingFromLocalFile();
        }

        private static void JsonLoadingFromLocalFile()
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
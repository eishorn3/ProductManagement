namespace ProductManagement


{
    public class Program
    {
        private IProductRepository _repository = new ProductRepository();

        public static void Main(string[] args)
        {
            var load = new JsonLoad();
            products = load.LoadProducts();

            while (true)
            {
                DisplayUserOptions();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Addd();
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

        private static void DisplayUserOptions()
        {
            Console.WriteLine("Hey! Welcome to our Douglas Prodcut Management Site.");
            Console.WriteLine("1: Add a product");
            Console.WriteLine("2: Show a product");
            Console.WriteLine("3: Edit a product");
            Console.WriteLine("4: Delete a product");
            Console.WriteLine("5: Close the Product Manager");

            Console.WriteLine("Choose an option: ");
        }

        public static void Addd()
        {

            Console.WriteLine("Enter L for Lipstick or P for Perfume: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "L")

            {
                Lipstick lipstick = new Lipstick();
                lipstick.AddTo();
                lipstick.WriteToConsole();
                products.Add(lipstick);
            }
            else if (userChoice == "P")
            {
                var perfume = new Perfume();
                perfume.questionsAdd();
                perfume.WriteToConsole();
                products.Add(perfume);
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
                Console.WriteLine(product);
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
            elementToEdit.questionsAdd();
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



        static void Close()
        {
            var save = new JsonSave(products);
            Environment.Exit(0);
        }



    }
}
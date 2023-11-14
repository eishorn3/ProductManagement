//using System.Text.Json;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Text.Json;

namespace ProductManagement


{
    public class Program
    {
        public static List<Product> products = new List<Product>();

        public static void Main(string[] args)
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
                Console.WriteLine("8: Save Changes in JSON");
                Console.WriteLine("9: Load Products from JSON");

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
                    case "8":
                        JSONSave();
                        break;
                    case "9":
                        JSONLoad();
                        break;
                    default:
                        Console.WriteLine("Sorry, wrong input");
                        break;
                }

                Console.WriteLine("\n");
            }
        }


        public static void Add()
        {
            Console.WriteLine("Enter L for Lipstick or P for Perfume: ");
            string userChoiceLipstick = "L";
            string userChoicePerfume = "P";
            string userChoice = Console.ReadLine();

            if (userChoice == userChoiceLipstick)

            {
                var lipstickproduct = new Lipstick();
                lipstickproduct.questionsAdd();

                lipstickproduct.WriteToConsole();
                products.Add(lipstickproduct);

            }
            else if (userChoice == userChoicePerfume)
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
                /*
                 * TODO
                 * Hier werden nur die Properties von der Mutterklasse Product erfasst.
                 * Wie könnte man hier die spezifischen Properties ebenfalls erfassen?
                 * Tipp: Typprüfung
                 */
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
                JsonSerializer serializer = new JsonSerializer();
                string json = JsonConvert.SerializeObject(products);
                using (StreamWriter file = File.CreateText("newy.txt"))
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                    string Serialized = JsonConvert.SerializeObject(products, settings);
                    Console.WriteLine(Serialized);

                    //var properties = new JsonSerializerOptions {IncludeFields = true, WriteIndented = true };
                    //var jsonString = JsonSerializer.Serialize(products, properties);
                    //Console.WriteLine(jsonString);
                    //FileStream createStream = File.Create(path: "jsonproductobjects.json");
                    //        JsonSerializer serializer = new JsonSerializer();
                    //JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All};
                    //string Serialized = JsonConvert.SerializeObject(products, settings);    
                    //Console.WriteLine(Serialized);


                }
                File.WriteAllText("newy.txt", JsonConvert.SerializeObject(products));

                //static void JSONLoad()
                //{
                //    var properties = new JsonSerializerOptions { IncludeFields = true };
                //    string jsonString = File.ReadAllText(@"C:\Users\j.glomb\Documents\ProductFiles\jsonproductobjects.txt");
                //    List<Product>products = JsonSerializer.Deserialize<List<Product>>(jsonString, properties);
                //    //JsonConverter<List<Product> vllt converten?;
                //    Show();




                //static void JSONSave()
                //{
                //    var properties = new JsonSerializerOptions { IncludeFields = true };
                //    var jsonString = JsonSerializer.Serialize(products, properties);
                //    File.WriteAllText("jsonproductobjects.json", jsonString);



                //}
                //static void JSONLoad()
                //{
                //    var properties = new JsonSerializerOptions { IncludeFields = true };
                //    string jsonString = File.ReadAllText(@"C:\Users\j.glomb\Documents\ProductFiles\jsonproductobjects.txt");
                //    List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonString, properties);
                //    string jsonString = File.ReadAllText("jsonproductobjects.json");
                //    products = JsonSerializer.Deserialize<List<Product>>(jsonString, properties);
                //    //JsonConverter<List<Product> vllt converten?;
                //    Show();
                // //}
                //public static void JSONLoad()
                // {
                // FileStream createStream = File.Create(path: "jsonproductobjects.json");
                // JsonSerializer serializer = new JsonSerializer();
                // JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                // string Serialized = JsonConvert.SerializeObject(products, settings);
                // Console.WriteLine(Serialized);
                // List<Product> deserializedList = JsonConvert.DeserializeObject<List<Product>>(Serialized, settings);

                //var properties = new JsonSerializerOptions { IncludeFields = true,
                //    WriteIndented = true
                //    };

                //string jsonString = File.ReadAllText(path: "jsonproductobjects.json");
                //products = JsonSerializer.Deserialize<List<Product>>(jsonString, properties);
                ////JsonConverter<List<Product> vllt converten?;
                //Show();

                //P value = JsonSerializer.Deserialize<List<Product>>(jsonString);
                //Console.WriteLine(value is Product);
            }

            //}


        }
        public static void JSONLoad()
        {
            //JsonDeserializer deserializer = new JsonDeserializer();
            //string json = JsonConvert.DeserializeObject(products);
            //using (StreamWriter file = File.CreateText(@"C:\Users\j.glomb\Documents\ProductFiles\newy.txt"))
            //{
            //    JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            //    string Serialized = JsonConvert.SerializeObject(products, settings);
            //    Console.WriteLine(Serialized);

            //    //var properties = new JsonSerializerOptions {IncludeFields = true, WriteIndented = true };
            //    //var jsonString = JsonSerializer.Serialize(products, properties);
            //    //Console.WriteLine(jsonString);
            //    //FileStream createStream = File.Create(path: "jsonproductobjects.json");
            //    //        JsonSerializer serializer = new JsonSerializer();
            //    //JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All};
            //    //string Serialized = JsonConvert.SerializeObject(products, settings);    
            //    //Console.WriteLine(Serialized);


            //}
            //File.WriteAllText(@"C:\Users\j.glomb\Documents\ProductFiles\newy.txt", JsonConvert.SerializeObject(products));
            //var res = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(@"C:\Users\j.glomb\Documents\ProductFiles\newy.txt"));
            //string json = JsonConvert.DeserializeObject(File.ReadAllText(@"C:\Users\j.glomb\Documents\ProductFiles\newy.txt"));
            //Console.WriteLine(res);
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            using (StreamReader file = File.OpenText("newy.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                var products2 = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("newy.txt"), settings);
                foreach (var item in products2)
                {
                    item.WriteToConsole();
                }
            }
        }

    }
}
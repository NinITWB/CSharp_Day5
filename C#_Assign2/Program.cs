using System;

namespace Task2
{
    class Program
    {
        static void Main(string [] args)
        {
            int option = 5;
            while (option != 0)
            {
                Console.WriteLine("Choose Options: ");
                Console.WriteLine("1. Add products.");
                Console.WriteLine("2. Search products.");
                Console.WriteLine("3. Display products information.");
                Console.WriteLine("AnyNums --> Exit.");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        StreamWriter writer = writer = new StreamWriter("Products.txt", true);;
                        AddProduct(writer);
                        break;
                    case 2: 
                        StreamReader searcher = new StreamReader("Products.txt");
                        SearchProduct(searcher);
                        break;
                    case 3:
                        StreamReader reader = new StreamReader("Products.txt");
                        DisplayProduct(reader);
                        break;
                    default: 
                        option = 0;
                        break;
                }
            }
        }

        static void AddProduct(StreamWriter writer)
        {
            int id;
            string name, productionName, otherDescriptions;
            double price;
            try
            {     
                Console.Write("Enter product's id: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter product's name: ");
                name = Console.ReadLine();
                Console.Write("Enter product's production name: ");
                productionName = Console.ReadLine();
                Console.Write("Enter product's price: ");
                price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter product's description: ");
                otherDescriptions = Console.ReadLine();
                
                Products product = new Products(id, name, productionName, price, otherDescriptions);
                if (!File.Exists("Products.txt"))
                {
                    writer.Write(product.ToString());
                    writer.Flush();
                } 
                else 
                {
                    writer.WriteLine(product.ToString());
                    writer.Flush();
                }    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writer.Dispose();
            }
        }

        static void SearchProduct(StreamReader reader)
        {
            int id;
            string line;
            Console.WriteLine("Enter id of product: ");
            id = Convert.ToInt32(Console.ReadLine());
            string newStr = "";
            bool isDone = false;
           
            try
            {
                while ((line = reader.ReadLine()) != null)
                {   
                    if (line.Contains($"Id: {id}"))
                    {
                        newStr += line + "\n";
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line == null || line.Contains("Id: "))
                            {
                                isDone = true;
                                break;
                            } 
                            newStr += line + "\n";
                            
                        }
                    }

                    if (isDone) break; 
                }

                Console.WriteLine(newStr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void DisplayProduct(StreamReader reader)
        {
            
            string line;
            try
            {
                line = reader.ReadToEnd();
                Console.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

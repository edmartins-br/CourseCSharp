using System;
using System.Collections.Generic;
using System.Globalization;
using VendaProduto.Entities;

namespace VendaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data: ");

                Console.Write("Commom, Used or Imported? (c / u / i): ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));

                    Console.WriteLine("-------------------------------------");


                }
                else if (ch == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Manufacture Date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProducts(name, price, date));

                    Console.WriteLine("-------------------------------------");
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Custom Fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, fee));

                    Console.WriteLine("-------------------------------------");
                }

                



            }

            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product emp in list)
            {
                Console.WriteLine(emp.priceTag());
            }

            
        }
    }
}

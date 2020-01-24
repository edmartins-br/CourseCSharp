using System;
using Empregado.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace Empregado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of emplyees: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // começo do FOR
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("Outsourced (y/n): ");
                char ch = Char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours =int.Parse( Console.ReadLine());

                Console.Write("Value per Hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, value, additionalCharge));
                    Console.WriteLine();
                }
                else
                {
                    list.Add(new Employee(name, hours, value));
                    Console.WriteLine();

                }


            }
            // fim do FOR

            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

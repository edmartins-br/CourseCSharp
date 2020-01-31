using System;
using System.Collections.Generic;
using Impostos.Entities;
using System.Globalization;

namespace Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contributor> list = new List<Contributor>();

            Console.Write("Enter the Number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Tax payer #{i} data: ");

                    Console.Write("idividual or Company? (i / c): ");
                    char ch = char.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Anual Income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (ch == 'i')
                    {              
                        Console.Write("Health expenditures: ");
                        double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Individual(name, income, health));

                        Console.WriteLine("====================================");
                    }
                    else
                    {
                        Console.Write("Number of Employees: ");
                        int employees = int.Parse(Console.ReadLine());

                        list.Add(new Company(name, income, employees));

                        Console.WriteLine("====================================");
                    }
                                
                }

            Console.WriteLine();
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=");
            Console.WriteLine("TAX PAYED:");

            foreach (Contributor tp in list)
            {
                Console.WriteLine(tp.Name + ": $"+ tp.TaxesCalc().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

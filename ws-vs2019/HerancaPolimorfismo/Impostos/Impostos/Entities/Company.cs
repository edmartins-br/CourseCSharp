using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos.Entities
{
    class Company : Contributor
    {
        //public string Name { get; set; }
        //public double Income { get; set; }
        public int Employees { get; set; }
        public double Taxes { get; set; }

        public Company(string name, double income, int employees)

        {
            Name = name;
            Income = income;
            Employees = employees;
        }

        public override double TaxesCalc()
        {


            if (Employees > 10)
            {
                return Taxes = (Income * 0.14);
            }
            else
            {
                return Taxes = (Income * 0.16);
            }
        }
    }
}

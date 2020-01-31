using Impostos.Entities;
using Impostos.Entities.Enums;

namespace Impostos.Entities
{
    class Individual : Contributor
    {
        //public string Name { get; set; }
        //public double Income { get; set; }
        public double Health { get; set; }
        public double Taxes { get; set; }

        public Individual(string name, double income, double health) 
            
        {
            Name = name;
            Income = income;
            Health = health;
        }

        public override double TaxesCalc()
        {
            
            
            if (Income <= 20000 && Health > 0)
            {
                return Taxes = (Income * 0.15) - (Health * 0.50);
            }
            else
            {
                return Taxes = (Income * 0.25) - (Health * 0.50);
            }
        }
    }
}

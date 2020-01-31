using System;
using System.Collections.Generic;
using System.Text;
using Impostos.Entities.Enums;
using Impostos.Entities;

namespace Impostos.Entities
{
    abstract class Contributor
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public abstract double TaxesCalc();
    }
}

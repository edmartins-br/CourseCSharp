using System;
using System.Collections.Generic;
using System.Text;
using VendaProduto.Entities;

namespace VendaProduto.Entities
    
{
    class UsedProducts : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProducts()
        {

        }

        public UsedProducts(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name + " (Used) $ " + Price + " (Manufacture Date: " + ManufactureDate + ") ";
        }

    }
}

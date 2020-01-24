using System;
using System.Collections.Generic;
using System.Text;

namespace VendaProduto.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }
        

        // construtor padrão da classe
        public ImportedProduct()
        {

        }

        // Construtor gerado automaticamente com a ferramenta chave de fenda
        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            this.customsFee = customsFee;
        }

        // Método para calcular o preço total
        public double totalPrice()
        {
            return Price + customsFee;
        }

        public override string priceTag()
        {
            return Name + " $ " + totalPrice() + " - Customs Fee: $ " + customsFee;
        }

       


    }
}

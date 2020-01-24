using System;
using System.Collections.Generic;
using System.Text;

namespace VendaProduto.Entities
{
    class Product
    {
        // declaração das variáveis
        public string Name { get; set; }
        public double Price { get; set; }

        // COnstrutor padrão
        public Product()
        {

        }

        // Construtor gerado automaticamente com a ferramenta chave de fenda
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Método para msotrar a TAG com nome e preço
        // Precisa ser virtual em razão do uso de polimorfismo, onde o método pode ser sobrescrito em outras classes
        // para mostrar resultados diferentes
        public virtual string priceTag()
        {
            return Name + " $ " + Price;
        }
    }
}

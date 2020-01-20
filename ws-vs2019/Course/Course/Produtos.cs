using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Produtos
    {

        private string _nome;
        // Auto Property (prop tab tab) Dessa forma não é necessário fazer a implementação la de baixo - **
        public double Preco { get; private set; }
        //***
        public int Quantidade { get; private set; }

        // public string Nome;
        // public double Preco;
        // public int Quantidade;
        // public double Total; - DESNECESSARIO
        // public int QuantidadeAdicional; - DESNECESSARIO
        // public int QuantidadeFinal; - DESNECESSARIO
        // public double TotalAtualizado; - DESNECESSARIO

        // Este é um construtor, ele serve para obrigar o programador a passar os parâmetros necessário
        // sem que se use o padrão genérico. O Construtor semrpe leva o nome da propria classe em que está.
        //public Produtos (string nome, double preco, int quantidade)
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = quantidade;
        //}


        // Neste caso o encapsulamento é feito por PROPERTIES, incluindo get e set dentro da propertie
        // O interessante é que se pode colocar lógica d eprogramação dentro da propertie que vai definir o valor da variavel

        //CONSTRUCTOR
        public Produtos(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Implementação manual da property - não da pra fazer AutoProp pois tem uma verificação
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                
                    _nome = value;
                else
                        Console.WriteLine("Digite no mínimo 2 caracteres!");
                    
                

            }
        }

        // **
        //public double Preco
        //{
        //    get { return _preco; }
        //}

        //***
        // public int Quantidade
        // {
        //    get { return _quantidade; }
        // }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionaProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + "R$"
                + Preco
                + ", "
                + Quantidade + " unidades, R$"
                + ValorTotalEmEstoque() + " em estoque";
        }
    }
}

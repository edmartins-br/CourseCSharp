using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Banco
    {
        public int NumeroConta { get; private set; }
        private string _nome;
        public double Saldo { get; private set; }

        // Construtor
        public Banco(string nome, int numeroConta, double depositoInicial)
        {
            _nome = nome;
            NumeroConta = numeroConta;
            Saldo = depositoInicial;
        }

        
        public string Nome
        {
            
            get { return _nome; }
            set
            {
                
                if (value != null && value.Length > 1)

                    _nome = value;
                else
                    Console.WriteLine("O nome do Titutlar NÃO foi aceito!");
                    Console.WriteLine("Digite no mínimo 2 caracteres!");
                    
            }
        }

        // Método criado para salvar o numero da conta
        public void SalvaConta(int conta)
        {
            NumeroConta = conta;
        }

        // Método que realiza o depósito inicial
        public double DepositoInicial(double inicial)
        {
            Saldo += inicial;
            return Saldo;
        }

        //Método para realizar um depósito adicional
        public double AdicionaDeposito(double depositoAdicional)
        {
            Saldo += depositoAdicional;
            return Saldo;
        }

        //Método para realizar um saque
        public double Saque(double Saque)
        {
            Saldo -= (Saque + 5);
            return Saldo;
        }

        // Override para mostrar todos os dados de uam só vez todos já atualizados.
        public override string ToString()
        {
            return "Conta Corrente nº: " 
                + NumeroConta
                + ", "
                + "Titular: "
                + _nome
                + ", Saldo: R$"
                + Saldo;
        }


    }
}
